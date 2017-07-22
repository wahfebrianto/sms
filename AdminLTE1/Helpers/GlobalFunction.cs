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
                else if (mode.ToUpper() == "PO")
                {
                    using (var db = new dbsmsEntities())
                    {
                        urutan = (from p in db.hpoes
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
                if (status_.suratjalan == value) { elements.Add("suratjalan"); }
                if (status_.salesinvoice == value) { elements.Add("salesinvoice"); }
                if (status_.salespayment == value) { elements.Add("salespayment"); }
                if (status_.purchaseinvoice == value) { elements.Add("purchaseinvoice"); }
                if (status_.purchasepayment == value) { elements.Add("purchasepayment"); }
            }
            return elements;
        }
    }
}