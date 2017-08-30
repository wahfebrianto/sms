using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AdminLTE1.Helpers
{
    public static class GlobalFunction
    {
        public static String generate_code(String mode)
        {
            String code = "SMS-"+mode.ToUpper()+"/";
            DateTime tgl = DateTime.Now;
            code += tgl.Month.ToString().PadLeft(2, '0') + "/";
            code += tgl.Year.ToString().Substring(2, 2) + "/";
            
            String urutan = "";
            try
            {
                if (mode.ToUpper() == "PNW")
                {
                    using (var db = new dbsmsEntities())
                    {
                        urutan = (from p in db.hpenawarans
                                  where p.number.Substring(0, 14) == code
                                  select p.number.Substring(14, 3)).Max();
                    }
                }
                else if (mode.ToUpper() == "INV")
                {
                    using (var db = new dbsmsEntities())
                    {
                        urutan = (from p in db.hsalesinvoices
                                  where p.number.Substring(0, 14) == code
                                  select p.number.Substring(14, 3)).Max();
                    }
                }
                else if (mode.ToUpper() == "RFQ")
                {
                    using (var db = new dbsmsEntities())
                    {
                        urutan = (from p in db.hrfqs
                                  where p.number.Substring(0, 14) == code
                                  select p.number.Substring(14, 3)).Max();
                    }
                }
                else if (mode.ToUpper() == "PO")
                {
                    using (var db = new dbsmsEntities())
                    {
                        urutan = (from p in db.hpoes
                                  where p.number.Substring(0, 13) == code
                                  select p.number.Substring(13, 3)).Max();
                    }
                }
                else if (mode.ToUpper() == "SO")
                {
                    using (var db = new dbsmsEntities())
                    {
                        urutan = (from p in db.hsalesorders
                                  where p.number.Substring(0, 13) == code
                                  select p.number.Substring(13, 3)).Max();
                    }
                }
                else if (mode.ToUpper() == "SJ")
                {
                    using (var db = new dbsmsEntities())
                    {
                        urutan = (from p in db.hsuratjalans
                                  where p.number.Substring(0, 13) == code
                                  select p.number.Substring(13, 3)).Max();
                    }
                }
                else if (mode.ToUpper() == "RI")
                {
                    using (var db = new dbsmsEntities())
                    {
                        urutan = (from p in db.hreceiveitems
                                  where p.number.Substring(0, 13) == code
                                  select p.number.Substring(13, 3)).Max();
                    }
                }
                else if (mode.ToUpper() == "DP")
                {
                    using (var db = new dbsmsEntities())
                    {
                        urutan = (from p in db.hreceiveitems
                                  where p.number.Substring(0, 13) == code
                                  select p.number.Substring(13, 3)).Max();
                    }
                }
            }
            catch
            {
                urutan = "000";
            }
            urutan = (Convert.ToInt32(urutan) + 1).ToString().PadLeft(3, '0');
            code += urutan;
            return code;
        }

        public static Boolean is_allowed(long projectId, String destination)
        {
            using (var db = new dbsmsEntities())
            {
                status projStatus = (from p in db.projects
                                     where p.id == projectId
                                     select p.status1).First();
                if (destination == "salespayment" && projStatus.salesinvoice == 1) return true;
                else if (destination == "salesinvoice" && projStatus.salesorder == 1) return true;
                else if (destination == "deliveryorder" && projStatus.receiveitem == 1) return true;
                else if (destination == "purchasepayment" && projStatus.purchaseinvoice == 1) return true;
                else if (destination == "purchaseinvoice" && projStatus.purchaseorder == 1) return true;
                else if (destination == "receiveitem" && projStatus.purchaseorder == 1) return true;
                else if (destination == "purchaseorder" && projStatus.salesorder == 1) return true;
                else if (destination == "salesorder" && projStatus.penawaran == 1) return true;
                else if (destination == "penawaran" && projStatus.findprices == 1) return true;
                else if (destination == "findprices" && projStatus.rfq == 1) return true;
                else if (destination == "suratjalan" && projStatus.receiveitem == 1) return true;
                else return false;
            }
        }

        public static List<String> getId(Int64 projectId, byte value)
        {
            List<String> elements = new List<string>();
            using(var db = new dbsmsEntities())
            {
                status status_ = db.projects.Find(projectId).status1;
                if (status_.rfq == value) {elements.Add("rfq");}
                if (status_.findprices == value) { elements.Add("findprices"); }
                if (status_.penawaran == value) { elements.Add("penawaran"); }
                if (status_.salesorder == value) { elements.Add("salesorder"); }
                if (status_.purchaseorder == value) { elements.Add("purchaseorder"); }
                if (status_.receiveitem == value) { elements.Add("receiveitem"); }
                if (status_.purchaseinvoice == value) { elements.Add("purchaseinvoice"); }
                if (status_.purchasepayment == value) { elements.Add("purchasepayment"); }
                if (status_.suratjalan == value) { elements.Add("suratjalan"); }
                if (status_.salesinvoice == value) { elements.Add("salesinvoice"); }
                if (status_.salespayment == value) { elements.Add("salespayment"); }
            }
            return elements;
        }

        public static Boolean has_finished(Int64 projectId, String controller)
        {
            using (var db = new dbsmsEntities())
            {
                Boolean result = true;
                try
                {
                    project p = db.projects.Find(projectId);
                    if (controller.ToLower() == "FindPrices".ToLower())
                    {
                        result = p.status1.findprices == 1;
                    }
                    else if (controller.ToLower() == "Penawaran".ToLower())
                    {
                        result = p.status1.penawaran == 1;
                    }
                    else if (controller.ToLower() == "SalesOrder".ToLower())
                    {
                        result = p.status1.salesorder == 1;
                    }
                    else if (controller.ToLower() == "PurchaseOrder".ToLower())
                    {
                        int count = p.hpoes.Where(x => x.status == 0).Count();
                        result = count <= 0;
                    }
                    else if (controller.ToLower() == "ReceiveItem".ToLower())
                    {
                        int count = p.hpoes.Where(x => x.status <= 1).Count();
                        result = count <= 0;
                    }
                    else if (controller.ToLower() == "PurchaseInvoice".ToLower())
                    {
                        int count = p.hpurchaseinvoices.Select(x => x.hpo.number).Distinct().Intersect(p.hpoes.Select(x => x.number)).Count();
                        result = count == p.hpoes.Count();
                    }
                    else if (controller.ToLower() == "PurchasePayment".ToLower())
                    {
                        int count = p.hpurchaseinvoices.Where(x => x.status == 0).Count();
                        result = count <= 0;
                    }
                    else if (controller.ToLower() == "SuratJalan".ToLower())
                    {
                        int count = p.hsalesorders.First().dsalesorders
                            .Select(x => x.itemcategoryid+x.itemdescription+x.qty )
                            .Intersect(
                                db.dsuratjalans.Where(x => x.hsuratjalan.projectid == p.id)
                                .GroupBy(x => new { x.itemcategoryid, x.itemdescription })
                                .Select(x =>x.Key.itemcategoryid + x.Key.itemdescription+ x.Sum(a => a.qty) )
                            ).Count();

                        result = count == p.hsalesorders.First().dsalesorders.Count();
                    }
                    else if (controller.ToLower() == "SalesInvoice".ToLower())
                    {
                        result = p.hsalesorders.First().total == p.hsalesinvoices.Sum(x => x.grandtotal) || p.hsalesorders.First().total == p.hsalesinvoices.Sum(x => x.grandtotal) + p.hsalesinvoices.Sum(x => x.diskon);
                    }
                    else if (controller.ToLower() == "SalesPayment".ToLower())
                    {
                        int count = p.hsalesinvoices.Where(x => x.status == 0).Count();
                        result = count <= 0;
                    }
                }
                catch(Exception e)
                {
                    result = false;
                }
                return result;
            }
        }

        public static Boolean has_privilege(String username, String action, String table)
        {
            using (var db = new dbsmsEntities())
            {

                Boolean result = false;
                try
                {
                    user userNow = (from u in db.users
                                where u.username == username
                                select u).First();
                
                    userNow.roles.ToList().ForEach(x =>
                    {
                        foreach (privilege item in x.privileges)
                        {
                            if (item.action.Contains(action) && item.tablename.Replace("_","") == table.Replace("_", ""))
                                result = true;
                        }
                    });
                }
                catch { }
                return result;
            }
        }

        public static Int64 get_max_id(String tableName)
        {
            Int64 id = -999;
            using (var db = new dbsmsEntities())
            {
                if (tableName == "customer")
                    id = (from i in db.customers
                                select i.id).Max();
                else if (tableName == "hrfq")
                    id = (from i in db.hrfqs
                          select i.id).Max();
                else if (tableName == "supplier")
                    id = (from i in db.suppliers
                          select i.id).Max();
                else if (tableName == "findprices")
                    id = (from i in db.findprices
                          select i.id).Max();
                else if (tableName == "hpenawaran")
                    id = (from i in db.hpenawarans
                          select i.id).Max();
                else if (tableName == "hsalesorder")
                    id = (from i in db.hsalesorders
                          select i.id).Max();
                else if (tableName == "hpurchaseinvoice")
                    id = (from i in db.hpurchaseinvoices
                          select i.id).Max();
                else if (tableName == "hsalesinvoice")
                    id = (from i in db.hsalesinvoices
                          select i.id).Max();
                else if (tableName == "project")
                    id = (from i in db.projects
                          select i.id).Max();
                else if (tableName == "purchasepayment")
                    id = (from i in db.purchasepayments
                          select i.id).Max();
                else if (tableName == "salespayment")
                    id = (from i in db.salespayments
                          select i.id).Max();
            }
            return id;
        }
    }
}