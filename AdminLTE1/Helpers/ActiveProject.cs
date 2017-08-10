using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AdminLTE1.Helpers
{
    public class ActiveProject
    {
        public string project;
        public string customername;
        public long projectid;
        public long id;
        public string status;
        public string desc;
        public string link;
        public ActiveProject(long id, long projectid, string project, string customername, string status, string desc, string link)
        {
            this.id = id;
            this.projectid = projectid;
            this.project = project;
            this.customername = customername;
            this.status = status;
            this.desc = desc;
            this.link = link;

        }
    }
}