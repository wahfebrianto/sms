USE [dbsms]
GO
ALTER TABLE [dbo].[user_role] DROP CONSTRAINT [FK_user_role_users]
GO
ALTER TABLE [dbo].[user_role] DROP CONSTRAINT [FK_user_role_roles]
GO
ALTER TABLE [dbo].[suratjalannote] DROP CONSTRAINT [FK_suratjalannote_projects]
GO
ALTER TABLE [dbo].[salespaymentnote] DROP CONSTRAINT [FK_salespaymentnote_projects]
GO
ALTER TABLE [dbo].[salespayment] DROP CONSTRAINT [FK_salespayment_hsalesinvoice]
GO
ALTER TABLE [dbo].[salespayment] DROP CONSTRAINT [FK_hsalespayment_projects]
GO
ALTER TABLE [dbo].[salesordernote] DROP CONSTRAINT [FK_salesordernote_projects]
GO
ALTER TABLE [dbo].[salesinvoicenote] DROP CONSTRAINT [FK_salesinvoicenote_projects]
GO
ALTER TABLE [dbo].[role_privilege] DROP CONSTRAINT [FK_role_privilege_roles]
GO
ALTER TABLE [dbo].[role_privilege] DROP CONSTRAINT [FK_role_privilege_privilege]
GO
ALTER TABLE [dbo].[rfqnote] DROP CONSTRAINT [FK_rfqnote_projects]
GO
ALTER TABLE [dbo].[receiveitemnote] DROP CONSTRAINT [FK_receiveitemnote_projects]
GO
ALTER TABLE [dbo].[purchasepaymentnote] DROP CONSTRAINT [FK_purchasepaymentnote_projects]
GO
ALTER TABLE [dbo].[purchasepayment] DROP CONSTRAINT [FK_hpurchasepayment_suppliers]
GO
ALTER TABLE [dbo].[purchasepayment] DROP CONSTRAINT [FK_hpurchasepayment_projects]
GO
ALTER TABLE [dbo].[purchasepayment] DROP CONSTRAINT [FK_hpurchasepayment_hpurchaseinvoice]
GO
ALTER TABLE [dbo].[purchaseinvoicenote] DROP CONSTRAINT [FK_purchaseinvoicenote_projects]
GO
ALTER TABLE [dbo].[projects] DROP CONSTRAINT [FK_projects_status]
GO
ALTER TABLE [dbo].[projects] DROP CONSTRAINT [FK_projects_customers]
GO
ALTER TABLE [dbo].[ponote] DROP CONSTRAINT [FK_ponote_projects]
GO
ALTER TABLE [dbo].[penawarannote] DROP CONSTRAINT [FK_penawarannote_projects]
GO
ALTER TABLE [dbo].[hsuratjalan] DROP CONSTRAINT [FK_hsuratjalan_projects]
GO
ALTER TABLE [dbo].[hsalesorder] DROP CONSTRAINT [FK_hsalesorder_projects]
GO
ALTER TABLE [dbo].[hsalesorder] DROP CONSTRAINT [FK_hsalesorder_customers]
GO
ALTER TABLE [dbo].[hsalesinvoice] DROP CONSTRAINT [FK_hsalesinvoice_projects]
GO
ALTER TABLE [dbo].[hsalesinvoice] DROP CONSTRAINT [FK_hsalesinvoice_customers]
GO
ALTER TABLE [dbo].[hrfq] DROP CONSTRAINT [FK_hrfq_projects]
GO
ALTER TABLE [dbo].[hrfq] DROP CONSTRAINT [FK_hrfq_customers]
GO
ALTER TABLE [dbo].[hreceiveitem] DROP CONSTRAINT [FK_hreceiveitem_suppliers]
GO
ALTER TABLE [dbo].[hreceiveitem] DROP CONSTRAINT [FK_hreceiveitem_projects]
GO
ALTER TABLE [dbo].[hreceiveitem] DROP CONSTRAINT [FK_hreceiveitem_hpo]
GO
ALTER TABLE [dbo].[hpurchaseinvoice] DROP CONSTRAINT [FK_purchaseinvoice_suppliers]
GO
ALTER TABLE [dbo].[hpurchaseinvoice] DROP CONSTRAINT [FK_purchaseinvoice_projects]
GO
ALTER TABLE [dbo].[hpurchaseinvoice] DROP CONSTRAINT [FK_purchaseinvoice_hpo]
GO
ALTER TABLE [dbo].[hpo] DROP CONSTRAINT [FK_hpo_suppliers]
GO
ALTER TABLE [dbo].[hpo] DROP CONSTRAINT [FK_hpo_projects]
GO
ALTER TABLE [dbo].[hpenawaran] DROP CONSTRAINT [FK_hpenawaran_projects1]
GO
ALTER TABLE [dbo].[hpenawaran] DROP CONSTRAINT [FK_hpenawaran_customers]
GO
ALTER TABLE [dbo].[findpricesnote] DROP CONSTRAINT [FK_findpricesnote_projects]
GO
ALTER TABLE [dbo].[findprices] DROP CONSTRAINT [FK_findprices_supplier]
GO
ALTER TABLE [dbo].[findprices] DROP CONSTRAINT [FK_findprices_projects1]
GO
ALTER TABLE [dbo].[findprices] DROP CONSTRAINT [FK_findprices_item_category]
GO
ALTER TABLE [dbo].[dsuratjalan] DROP CONSTRAINT [FK_dsuratjalan_item_category]
GO
ALTER TABLE [dbo].[dsuratjalan] DROP CONSTRAINT [FK_dsuratjalan_hsuratjalan]
GO
ALTER TABLE [dbo].[dsalesorder] DROP CONSTRAINT [FK_dsalesorder_item_category]
GO
ALTER TABLE [dbo].[dsalesorder] DROP CONSTRAINT [FK_dsalesorder_hsalesorder]
GO
ALTER TABLE [dbo].[dsalesinvoice] DROP CONSTRAINT [FK_dsalesinvoice_item_category]
GO
ALTER TABLE [dbo].[dsalesinvoice] DROP CONSTRAINT [FK_dsalesinvoice_hsalesinvoice]
GO
ALTER TABLE [dbo].[drfq] DROP CONSTRAINT [FK_drfq_item_category]
GO
ALTER TABLE [dbo].[drfq] DROP CONSTRAINT [FK_drfq_hrfq]
GO
ALTER TABLE [dbo].[dreceiveitem] DROP CONSTRAINT [FK_dreceiveitem_item_category]
GO
ALTER TABLE [dbo].[dreceiveitem] DROP CONSTRAINT [FK_dreceiveitem_hreceiveitem]
GO
ALTER TABLE [dbo].[dpurchaseinvoice] DROP CONSTRAINT [FK_dpurchaseinvoice_item_category]
GO
ALTER TABLE [dbo].[dpurchaseinvoice] DROP CONSTRAINT [FK_dpurchaseinvoice_dpurchaseinvoice]
GO
ALTER TABLE [dbo].[dpo] DROP CONSTRAINT [FK_dpo_item_category]
GO
ALTER TABLE [dbo].[dpo] DROP CONSTRAINT [FK_dpo_hpo]
GO
ALTER TABLE [dbo].[dpenawaran] DROP CONSTRAINT [FK_dpenawaran_suppliers]
GO
ALTER TABLE [dbo].[dpenawaran] DROP CONSTRAINT [FK_dpenawaran_item_category]
GO
ALTER TABLE [dbo].[dpenawaran] DROP CONSTRAINT [FK_dpenawaran_hpenawaran]
GO
ALTER TABLE [dbo].[status] DROP CONSTRAINT [DF_status_salespayment]
GO
ALTER TABLE [dbo].[status] DROP CONSTRAINT [DF_status_salesinvoice]
GO
ALTER TABLE [dbo].[status] DROP CONSTRAINT [DF_status_suratjalan]
GO
ALTER TABLE [dbo].[status] DROP CONSTRAINT [DF_status_purchasepayment]
GO
ALTER TABLE [dbo].[status] DROP CONSTRAINT [DF_status_purchaseinvoice]
GO
ALTER TABLE [dbo].[status] DROP CONSTRAINT [DF_status_receiveitem]
GO
ALTER TABLE [dbo].[status] DROP CONSTRAINT [DF_status_purchaseorder]
GO
ALTER TABLE [dbo].[status] DROP CONSTRAINT [DF_status_salesorder]
GO
ALTER TABLE [dbo].[status] DROP CONSTRAINT [DF_status_penawaran]
GO
ALTER TABLE [dbo].[status] DROP CONSTRAINT [DF_status_findprices]
GO
ALTER TABLE [dbo].[status] DROP CONSTRAINT [DF_status_rfq]
GO
ALTER TABLE [dbo].[hsalesinvoice] DROP CONSTRAINT [DF_hsalesinvoice_status]
GO
ALTER TABLE [dbo].[hsalesinvoice] DROP CONSTRAINT [DF_hsalesinvoice_grandtotal]
GO
ALTER TABLE [dbo].[hsalesinvoice] DROP CONSTRAINT [DF_hsalesinvoice_diskon]
GO
ALTER TABLE [dbo].[hpurchaseinvoice] DROP CONSTRAINT [DF_hpurchaseinvoice_status]
GO
ALTER TABLE [dbo].[hpurchaseinvoice] DROP CONSTRAINT [DF_hpurchaseinvoice_grandtotal]
GO
ALTER TABLE [dbo].[hpo] DROP CONSTRAINT [DF_hpo_status]
GO
ALTER TABLE [dbo].[findprices] DROP CONSTRAINT [DF_findprices_status]
GO
/****** Object:  Table [dbo].[users]    Script Date: 8/30/2017 3:43:48 PM ******/
DROP TABLE [dbo].[users]
GO
/****** Object:  Table [dbo].[user_role]    Script Date: 8/30/2017 3:43:48 PM ******/
DROP TABLE [dbo].[user_role]
GO
/****** Object:  Table [dbo].[suratjalannote]    Script Date: 8/30/2017 3:43:48 PM ******/
DROP TABLE [dbo].[suratjalannote]
GO
/****** Object:  Table [dbo].[suppliers]    Script Date: 8/30/2017 3:43:48 PM ******/
DROP TABLE [dbo].[suppliers]
GO
/****** Object:  Table [dbo].[status]    Script Date: 8/30/2017 3:43:48 PM ******/
DROP TABLE [dbo].[status]
GO
/****** Object:  Table [dbo].[salespaymentnote]    Script Date: 8/30/2017 3:43:48 PM ******/
DROP TABLE [dbo].[salespaymentnote]
GO
/****** Object:  Table [dbo].[salespayment]    Script Date: 8/30/2017 3:43:48 PM ******/
DROP TABLE [dbo].[salespayment]
GO
/****** Object:  Table [dbo].[salesordernote]    Script Date: 8/30/2017 3:43:48 PM ******/
DROP TABLE [dbo].[salesordernote]
GO
/****** Object:  Table [dbo].[salesinvoicenote]    Script Date: 8/30/2017 3:43:48 PM ******/
DROP TABLE [dbo].[salesinvoicenote]
GO
/****** Object:  Table [dbo].[roles]    Script Date: 8/30/2017 3:43:48 PM ******/
DROP TABLE [dbo].[roles]
GO
/****** Object:  Table [dbo].[role_privilege]    Script Date: 8/30/2017 3:43:48 PM ******/
DROP TABLE [dbo].[role_privilege]
GO
/****** Object:  Table [dbo].[rfqnote]    Script Date: 8/30/2017 3:43:48 PM ******/
DROP TABLE [dbo].[rfqnote]
GO
/****** Object:  Table [dbo].[receiveitemnote]    Script Date: 8/30/2017 3:43:48 PM ******/
DROP TABLE [dbo].[receiveitemnote]
GO
/****** Object:  Table [dbo].[purchasepaymentnote]    Script Date: 8/30/2017 3:43:48 PM ******/
DROP TABLE [dbo].[purchasepaymentnote]
GO
/****** Object:  Table [dbo].[purchasepayment]    Script Date: 8/30/2017 3:43:48 PM ******/
DROP TABLE [dbo].[purchasepayment]
GO
/****** Object:  Table [dbo].[purchaseinvoicenote]    Script Date: 8/30/2017 3:43:48 PM ******/
DROP TABLE [dbo].[purchaseinvoicenote]
GO
/****** Object:  Table [dbo].[projects]    Script Date: 8/30/2017 3:43:48 PM ******/
DROP TABLE [dbo].[projects]
GO
/****** Object:  Table [dbo].[privileges]    Script Date: 8/30/2017 3:43:48 PM ******/
DROP TABLE [dbo].[privileges]
GO
/****** Object:  Table [dbo].[ponote]    Script Date: 8/30/2017 3:43:48 PM ******/
DROP TABLE [dbo].[ponote]
GO
/****** Object:  Table [dbo].[penawarannote]    Script Date: 8/30/2017 3:43:48 PM ******/
DROP TABLE [dbo].[penawarannote]
GO
/****** Object:  Table [dbo].[item_category]    Script Date: 8/30/2017 3:43:48 PM ******/
DROP TABLE [dbo].[item_category]
GO
/****** Object:  Table [dbo].[hsuratjalan]    Script Date: 8/30/2017 3:43:48 PM ******/
DROP TABLE [dbo].[hsuratjalan]
GO
/****** Object:  Table [dbo].[hsalesorder]    Script Date: 8/30/2017 3:43:48 PM ******/
DROP TABLE [dbo].[hsalesorder]
GO
/****** Object:  Table [dbo].[hsalesinvoice]    Script Date: 8/30/2017 3:43:48 PM ******/
DROP TABLE [dbo].[hsalesinvoice]
GO
/****** Object:  Table [dbo].[hrfq]    Script Date: 8/30/2017 3:43:48 PM ******/
DROP TABLE [dbo].[hrfq]
GO
/****** Object:  Table [dbo].[hreceiveitem]    Script Date: 8/30/2017 3:43:48 PM ******/
DROP TABLE [dbo].[hreceiveitem]
GO
/****** Object:  Table [dbo].[hpurchaseinvoice]    Script Date: 8/30/2017 3:43:48 PM ******/
DROP TABLE [dbo].[hpurchaseinvoice]
GO
/****** Object:  Table [dbo].[hpo]    Script Date: 8/30/2017 3:43:48 PM ******/
DROP TABLE [dbo].[hpo]
GO
/****** Object:  Table [dbo].[hpenawaran]    Script Date: 8/30/2017 3:43:48 PM ******/
DROP TABLE [dbo].[hpenawaran]
GO
/****** Object:  Table [dbo].[helper]    Script Date: 8/30/2017 3:43:48 PM ******/
DROP TABLE [dbo].[helper]
GO
/****** Object:  Table [dbo].[findpricesnote]    Script Date: 8/30/2017 3:43:48 PM ******/
DROP TABLE [dbo].[findpricesnote]
GO
/****** Object:  Table [dbo].[findprices]    Script Date: 8/30/2017 3:43:48 PM ******/
DROP TABLE [dbo].[findprices]
GO
/****** Object:  Table [dbo].[dsuratjalan]    Script Date: 8/30/2017 3:43:48 PM ******/
DROP TABLE [dbo].[dsuratjalan]
GO
/****** Object:  Table [dbo].[dsalesorder]    Script Date: 8/30/2017 3:43:48 PM ******/
DROP TABLE [dbo].[dsalesorder]
GO
/****** Object:  Table [dbo].[dsalesinvoice]    Script Date: 8/30/2017 3:43:48 PM ******/
DROP TABLE [dbo].[dsalesinvoice]
GO
/****** Object:  Table [dbo].[drfq]    Script Date: 8/30/2017 3:43:48 PM ******/
DROP TABLE [dbo].[drfq]
GO
/****** Object:  Table [dbo].[dreceiveitem]    Script Date: 8/30/2017 3:43:48 PM ******/
DROP TABLE [dbo].[dreceiveitem]
GO
/****** Object:  Table [dbo].[dpurchaseinvoice]    Script Date: 8/30/2017 3:43:48 PM ******/
DROP TABLE [dbo].[dpurchaseinvoice]
GO
/****** Object:  Table [dbo].[dpo]    Script Date: 8/30/2017 3:43:48 PM ******/
DROP TABLE [dbo].[dpo]
GO
/****** Object:  Table [dbo].[dpenawaran]    Script Date: 8/30/2017 3:43:48 PM ******/
DROP TABLE [dbo].[dpenawaran]
GO
/****** Object:  Table [dbo].[customers]    Script Date: 8/30/2017 3:43:48 PM ******/
DROP TABLE [dbo].[customers]
GO

/****** Object:  Table [dbo].[customers]    Script Date: 8/30/2017 3:43:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[customers](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[name] [text] NOT NULL,
	[address] [text] NOT NULL,
	[city] [text] NOT NULL,
	[phone] [text] NULL,
	[description] [text] NULL,
	[status] [tinyint] NOT NULL,
 CONSTRAINT [PK_customer] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[dpenawaran]    Script Date: 8/30/2017 3:43:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[dpenawaran](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[penawaranid] [bigint] NOT NULL,
	[itemcategoryid] [bigint] NOT NULL,
	[itemdescription] [text] NOT NULL,
	[supplierid] [bigint] NOT NULL,
	[qty] [bigint] NOT NULL,
	[unitprice] [bigint] NOT NULL,
	[subtotal] [bigint] NOT NULL,
 CONSTRAINT [PK_hpenawaran] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[dpo]    Script Date: 8/30/2017 3:43:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[dpo](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[poid] [bigint] NOT NULL,
	[itemcategoryid] [bigint] NOT NULL,
	[itemdescription] [text] NOT NULL,
	[qty] [bigint] NOT NULL,
	[unitprice] [bigint] NOT NULL,
	[subtotal] [bigint] NOT NULL,
 CONSTRAINT [PK_dpo] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[dpurchaseinvoice]    Script Date: 8/30/2017 3:43:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[dpurchaseinvoice](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[purchaseinvoiceid] [bigint] NOT NULL,
	[itemcategoryid] [bigint] NOT NULL,
	[itemdescription] [text] NOT NULL,
	[qty] [bigint] NOT NULL,
	[unitprice] [bigint] NOT NULL,
	[subtotal] [bigint] NOT NULL,
 CONSTRAINT [PK_dpurchaseinvoice] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[dreceiveitem]    Script Date: 8/30/2017 3:43:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[dreceiveitem](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[receiveitemid] [bigint] NOT NULL,
	[itemcategoryid] [bigint] NOT NULL,
	[itemdescription] [text] NOT NULL,
	[qty] [bigint] NOT NULL,
 CONSTRAINT [PK_dreceiveitem] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[drfq]    Script Date: 8/30/2017 3:43:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[drfq](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[rfqid] [bigint] NOT NULL,
	[itemcategoryid] [bigint] NOT NULL,
	[itemdescription] [text] NOT NULL,
	[qty] [bigint] NOT NULL,
	[unitprice] [bigint] NOT NULL,
	[subtotal] [bigint] NOT NULL,
 CONSTRAINT [PK_drfq] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[dsalesinvoice]    Script Date: 8/30/2017 3:43:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[dsalesinvoice](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[salesinvoiceid] [bigint] NOT NULL,
	[itemcategoryid] [bigint] NOT NULL,
	[itemdescription] [varchar](max) NOT NULL,
	[qty] [bigint] NOT NULL,
	[unitprice] [bigint] NOT NULL,
	[subtotal] [bigint] NOT NULL,
 CONSTRAINT [PK_dsalesinvoice] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[dsalesorder]    Script Date: 8/30/2017 3:43:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[dsalesorder](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[salesorderid] [bigint] NOT NULL,
	[itemcategoryid] [bigint] NOT NULL,
	[itemdescription] [varchar](max) NOT NULL,
	[qty] [bigint] NOT NULL,
	[unitprice] [bigint] NOT NULL,
	[subtotal] [bigint] NOT NULL,
 CONSTRAINT [PK_dsalesorder] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[dsuratjalan]    Script Date: 8/30/2017 3:43:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[dsuratjalan](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[suratjalanid] [bigint] NOT NULL,
	[itemcategoryid] [bigint] NOT NULL,
	[itemdescription] [varchar](max) NOT NULL,
	[qty] [bigint] NOT NULL,
 CONSTRAINT [PK_dsuratjalan] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[findprices]    Script Date: 8/30/2017 3:43:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[findprices](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[projectid] [bigint] NOT NULL,
	[supplierid] [bigint] NOT NULL,
	[address] [text] NOT NULL,
	[itemcategoryid] [bigint] NOT NULL,
	[itemdescription] [text] NOT NULL,
	[qty] [bigint] NOT NULL,
	[unitprice] [bigint] NOT NULL,
	[timeneeded] [bigint] NOT NULL,
	[description] [text] NULL,
	[status] [tinyint] NOT NULL,
 CONSTRAINT [PK_findprices] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[findpricesnote]    Script Date: 8/30/2017 3:43:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[findpricesnote](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[projectid] [bigint] NOT NULL,
	[username] [text] NOT NULL,
	[date] [date] NOT NULL,
	[text] [text] NOT NULL,
 CONSTRAINT [PK_findpricesnote] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[helper]    Script Date: 8/30/2017 3:43:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[helper](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[key] [text] NOT NULL,
	[value] [text] NOT NULL,
 CONSTRAINT [PK_helper] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[hpenawaran]    Script Date: 8/30/2017 3:43:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[hpenawaran](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[projectid] [bigint] NOT NULL,
	[number] [varchar](50) NOT NULL,
	[customerid] [bigint] NOT NULL,
	[date] [date] NOT NULL,
	[to] [text] NOT NULL,
	[description] [text] NULL,
	[total] [bigint] NOT NULL,
	[disc] [bigint] NOT NULL,
	[grandtotal] [bigint] NOT NULL,
 CONSTRAINT [PK_hpenawaran_1] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[hpo]    Script Date: 8/30/2017 3:43:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[hpo](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[projectid] [bigint] NOT NULL,
	[number] [varchar](50) NOT NULL,
	[supplierid] [bigint] NOT NULL,
	[date] [date] NOT NULL,
	[terms] [text] NOT NULL,
	[to] [text] NOT NULL,
	[expecteddate] [date] NOT NULL,
	[total] [bigint] NOT NULL,
	[dp] [bigint] NOT NULL,
	[discount] [bigint] NOT NULL,
	[grandtotal] [bigint] NOT NULL,
	[description] [text] NULL,
	[status] [tinyint] NOT NULL,
 CONSTRAINT [PK_hpo] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[hpurchaseinvoice]    Script Date: 8/30/2017 3:43:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[hpurchaseinvoice](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[projectid] [bigint] NOT NULL,
	[number] [text] NOT NULL,
	[date] [date] NOT NULL,
	[terms] [text] NOT NULL,
	[poid] [bigint] NOT NULL,
	[supplierid] [bigint] NOT NULL,
	[total] [bigint] NOT NULL,
	[diskon] [bigint] NOT NULL,
	[grandtotal] [bigint] NOT NULL,
	[description] [text] NULL,
	[status] [tinyint] NOT NULL,
 CONSTRAINT [PK_purchaseinvoice] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[hreceiveitem]    Script Date: 8/30/2017 3:43:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[hreceiveitem](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[projectid] [bigint] NOT NULL,
	[number] [varchar](50) NOT NULL,
	[poid] [bigint] NOT NULL,
	[date] [date] NOT NULL,
	[supplierid] [bigint] NOT NULL,
	[description] [text] NULL,
 CONSTRAINT [PK_hreceiveitem] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[hrfq]    Script Date: 8/30/2017 3:43:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[hrfq](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[number] [text] NULL,
	[date] [date] NOT NULL,
	[customerid] [bigint] NOT NULL,
	[to] [text] NULL,
	[description] [text] NULL,
	[projectid] [bigint] NOT NULL,
 CONSTRAINT [PK_hrfq] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[hsalesinvoice]    Script Date: 8/30/2017 3:43:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[hsalesinvoice](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[projectid] [bigint] NOT NULL,
	[customerid] [bigint] NOT NULL,
	[number] [varchar](50) NOT NULL,
	[date] [date] NOT NULL,
	[terms] [text] NOT NULL,
	[total] [bigint] NOT NULL,
	[description] [text] NULL,
	[diskon] [bigint] NOT NULL,
	[grandtotal] [bigint] NOT NULL,
	[status] [tinyint] NOT NULL,
 CONSTRAINT [PK_hsalesinvoice] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[hsalesorder]    Script Date: 8/30/2017 3:43:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[hsalesorder](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[projectid] [bigint] NOT NULL,
	[customerid] [bigint] NOT NULL,
	[number] [text] NOT NULL,
	[date] [date] NOT NULL,
	[expecteddate] [date] NOT NULL,
	[designdate] [date] NULL,
	[terms] [text] NOT NULL,
	[description] [text] NULL,
	[total] [bigint] NOT NULL,
	[dp] [bigint] NOT NULL,
	[grandtotal] [bigint] NOT NULL,
 CONSTRAINT [PK_hsalesorder] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[hsuratjalan]    Script Date: 8/30/2017 3:43:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[hsuratjalan](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[projectid] [bigint] NOT NULL,
	[number] [varchar](50) NOT NULL,
	[date] [date] NOT NULL,
	[to] [text] NOT NULL,
	[description] [text] NULL,
 CONSTRAINT [PK_hsuratjalan] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[item_category]    Script Date: 8/30/2017 3:43:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[item_category](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[name] [text] NOT NULL,
	[description] [text] NULL,
	[status] [tinyint] NOT NULL,
 CONSTRAINT [PK_item_category] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[penawarannote]    Script Date: 8/30/2017 3:43:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[penawarannote](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[projectid] [bigint] NOT NULL,
	[username] [text] NOT NULL,
	[date] [date] NOT NULL,
	[text] [text] NOT NULL,
 CONSTRAINT [PK_penawarannote] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ponote]    Script Date: 8/30/2017 3:43:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ponote](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[projectid] [bigint] NOT NULL,
	[username] [text] NOT NULL,
	[date] [date] NOT NULL,
	[text] [text] NOT NULL,
 CONSTRAINT [PK_ponote] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[privileges]    Script Date: 8/30/2017 3:43:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[privileges](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[action] [varchar](50) NOT NULL,
	[tablename] [varchar](50) NOT NULL,
 CONSTRAINT [PK_privilege] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[projects]    Script Date: 8/30/2017 3:43:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[projects](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[name] [text] NOT NULL,
	[customerid] [bigint] NULL,
	[statusid] [bigint] NOT NULL,
	[description] [text] NULL,
	[status] [tinyint] NOT NULL,
 CONSTRAINT [PK_projects] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[purchaseinvoicenote]    Script Date: 8/30/2017 3:43:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[purchaseinvoicenote](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[projectid] [bigint] NOT NULL,
	[username] [text] NOT NULL,
	[date] [date] NOT NULL,
	[text] [text] NOT NULL,
 CONSTRAINT [PK_purchaseinvoicenote] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[purchasepayment]    Script Date: 8/30/2017 3:43:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[purchasepayment](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[projectid] [bigint] NOT NULL,
	[purchaseinvoiceid] [bigint] NOT NULL,
	[number] [text] NOT NULL,
	[date] [date] NOT NULL,
	[supplierid] [bigint] NOT NULL,
	[total] [bigint] NOT NULL,
	[description] [text] NULL,
	[type] [text] NOT NULL,
	[note] [text] NULL,
 CONSTRAINT [PK_hpurchasepayment] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[purchasepaymentnote]    Script Date: 8/30/2017 3:43:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[purchasepaymentnote](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[projectid] [bigint] NOT NULL,
	[username] [text] NOT NULL,
	[date] [date] NOT NULL,
	[text] [text] NOT NULL,
 CONSTRAINT [PK_purchasepaymentnote] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[receiveitemnote]    Script Date: 8/30/2017 3:43:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[receiveitemnote](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[projectid] [bigint] NOT NULL,
	[username] [text] NOT NULL,
	[date] [date] NOT NULL,
	[text] [text] NOT NULL,
 CONSTRAINT [PK_receiveitemnote] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[rfqnote]    Script Date: 8/30/2017 3:43:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[rfqnote](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[projectid] [bigint] NOT NULL,
	[username] [text] NOT NULL,
	[date] [date] NOT NULL,
	[text] [text] NOT NULL,
 CONSTRAINT [PK_rfqnote] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[role_privilege]    Script Date: 8/30/2017 3:43:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[role_privilege](
	[roleid] [bigint] NOT NULL,
	[privilegeid] [bigint] NOT NULL,
 CONSTRAINT [PK_role_privilege] PRIMARY KEY CLUSTERED 
(
	[roleid] ASC,
	[privilegeid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[roles]    Script Date: 8/30/2017 3:43:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[roles](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[name] [text] NOT NULL,
	[description] [text] NULL,
 CONSTRAINT [PK_roles] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[salesinvoicenote]    Script Date: 8/30/2017 3:43:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[salesinvoicenote](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[projectid] [bigint] NOT NULL,
	[username] [text] NOT NULL,
	[date] [date] NOT NULL,
	[text] [text] NOT NULL,
 CONSTRAINT [PK_salesinvoicenote] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[salesordernote]    Script Date: 8/30/2017 3:43:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[salesordernote](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[projectid] [bigint] NOT NULL,
	[username] [text] NOT NULL,
	[date] [date] NOT NULL,
	[text] [text] NOT NULL,
 CONSTRAINT [PK_salesordernote] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[salespayment]    Script Date: 8/30/2017 3:43:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[salespayment](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[projectid] [bigint] NOT NULL,
	[number] [text] NOT NULL,
	[salesinvoiceid] [bigint] NOT NULL,
	[date] [date] NOT NULL,
	[to] [text] NOT NULL,
	[total] [bigint] NOT NULL,
	[description] [text] NULL,
	[type] [text] NOT NULL,
	[note] [text] NULL,
 CONSTRAINT [PK_hsalespayment] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[salespaymentnote]    Script Date: 8/30/2017 3:43:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[salespaymentnote](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[projectid] [bigint] NOT NULL,
	[username] [text] NOT NULL,
	[date] [date] NOT NULL,
	[text] [text] NOT NULL,
 CONSTRAINT [PK_salespaymentnote] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[status]    Script Date: 8/30/2017 3:43:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[status](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[rfq] [tinyint] NOT NULL,
	[findprices] [tinyint] NOT NULL,
	[penawaran] [tinyint] NOT NULL,
	[salesorder] [tinyint] NOT NULL,
	[purchaseorder] [tinyint] NOT NULL,
	[receiveitem] [tinyint] NOT NULL,
	[purchaseinvoice] [tinyint] NOT NULL,
	[purchasepayment] [tinyint] NOT NULL,
	[suratjalan] [tinyint] NOT NULL,
	[salesinvoice] [tinyint] NOT NULL,
	[salespayment] [tinyint] NOT NULL,
 CONSTRAINT [PK_status] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[suppliers]    Script Date: 8/30/2017 3:43:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[suppliers](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[name] [text] NOT NULL,
	[address] [text] NOT NULL,
	[city] [text] NOT NULL,
	[phone] [text] NULL,
	[description] [text] NULL,
	[status] [tinyint] NOT NULL,
 CONSTRAINT [PK_supplier] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[suratjalannote]    Script Date: 8/30/2017 3:43:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[suratjalannote](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[projectid] [bigint] NOT NULL,
	[username] [text] NOT NULL,
	[date] [date] NOT NULL,
	[text] [text] NOT NULL,
 CONSTRAINT [PK_suratjalannote] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[user_role]    Script Date: 8/30/2017 3:43:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[user_role](
	[userid] [bigint] NOT NULL,
	[roleid] [bigint] NOT NULL,
 CONSTRAINT [PK_user_role] PRIMARY KEY CLUSTERED 
(
	[userid] ASC,
	[roleid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[users]    Script Date: 8/30/2017 3:43:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[users](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[name] [text] NOT NULL,
	[username] [varchar](50) NOT NULL,
	[password] [varchar](50) NOT NULL,
	[description] [text] NULL,
	[status] [tinyint] NOT NULL,
 CONSTRAINT [PK_users] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO


SET IDENTITY_INSERT [dbo].[item_category] ON 

INSERT [dbo].[item_category] ([id], [name], [description], [status]) VALUES (2, N'DP', NULL, 0)
SET IDENTITY_INSERT [dbo].[item_category] OFF
SET IDENTITY_INSERT [dbo].[privileges] ON 

INSERT [dbo].[privileges] ([id], [action], [tablename]) VALUES (1, N'select', N'rfq')
INSERT [dbo].[privileges] ([id], [action], [tablename]) VALUES (2, N'insert', N'rfq')
INSERT [dbo].[privileges] ([id], [action], [tablename]) VALUES (5, N'select', N'find_price')
INSERT [dbo].[privileges] ([id], [action], [tablename]) VALUES (7, N'insert', N'find_price')
INSERT [dbo].[privileges] ([id], [action], [tablename]) VALUES (9, N'update_or_delete', N'find_price')
INSERT [dbo].[privileges] ([id], [action], [tablename]) VALUES (11, N'select', N'penawaran')
INSERT [dbo].[privileges] ([id], [action], [tablename]) VALUES (12, N'insert', N'penawaran')
INSERT [dbo].[privileges] ([id], [action], [tablename]) VALUES (13, N'update_or_delete', N'penawaran')
INSERT [dbo].[privileges] ([id], [action], [tablename]) VALUES (15, N'select', N'purchase_order')
INSERT [dbo].[privileges] ([id], [action], [tablename]) VALUES (16, N'insert', N'purchase_order')
INSERT [dbo].[privileges] ([id], [action], [tablename]) VALUES (17, N'update_or_delete', N'purchase_order')
INSERT [dbo].[privileges] ([id], [action], [tablename]) VALUES (19, N'select', N'sales_order')
INSERT [dbo].[privileges] ([id], [action], [tablename]) VALUES (20, N'insert', N'sales_order')
INSERT [dbo].[privileges] ([id], [action], [tablename]) VALUES (21, N'update_or_delete', N'sales_order')
INSERT [dbo].[privileges] ([id], [action], [tablename]) VALUES (23, N'select', N'sales_invoice')
INSERT [dbo].[privileges] ([id], [action], [tablename]) VALUES (24, N'insert', N'sales_invoice')
INSERT [dbo].[privileges] ([id], [action], [tablename]) VALUES (25, N'update_or_delete', N'sales_invoice')
INSERT [dbo].[privileges] ([id], [action], [tablename]) VALUES (27, N'select', N'sales_payment')
INSERT [dbo].[privileges] ([id], [action], [tablename]) VALUES (28, N'insert', N'sales_payment')
INSERT [dbo].[privileges] ([id], [action], [tablename]) VALUES (29, N'update_or_delete', N'sales_payment')
INSERT [dbo].[privileges] ([id], [action], [tablename]) VALUES (31, N'select', N'purchase_invoice')
INSERT [dbo].[privileges] ([id], [action], [tablename]) VALUES (32, N'insert', N'purchase_invoice')
INSERT [dbo].[privileges] ([id], [action], [tablename]) VALUES (33, N'update_or_delete', N'purchase_invoice')
INSERT [dbo].[privileges] ([id], [action], [tablename]) VALUES (35, N'select', N'purchase_payment')
INSERT [dbo].[privileges] ([id], [action], [tablename]) VALUES (36, N'insert', N'purchase_payment')
INSERT [dbo].[privileges] ([id], [action], [tablename]) VALUES (37, N'update_or_delete', N'purchase_payment')
INSERT [dbo].[privileges] ([id], [action], [tablename]) VALUES (39, N'select', N'receive_item')
INSERT [dbo].[privileges] ([id], [action], [tablename]) VALUES (40, N'insert', N'receive_item')
INSERT [dbo].[privileges] ([id], [action], [tablename]) VALUES (41, N'update_or_delete', N'receive_item')
INSERT [dbo].[privileges] ([id], [action], [tablename]) VALUES (43, N'select', N'surat_jalan')
INSERT [dbo].[privileges] ([id], [action], [tablename]) VALUES (44, N'insert', N'surat_jalan')
INSERT [dbo].[privileges] ([id], [action], [tablename]) VALUES (45, N'update_or_delete', N'surat_jalan')
INSERT [dbo].[privileges] ([id], [action], [tablename]) VALUES (47, N'select', N'master_kategori')
INSERT [dbo].[privileges] ([id], [action], [tablename]) VALUES (53, N'insert', N'master_kategori')
INSERT [dbo].[privileges] ([id], [action], [tablename]) VALUES (54, N'update_or_delete', N'master_kategori')
INSERT [dbo].[privileges] ([id], [action], [tablename]) VALUES (55, N'select', N'master_customer')
INSERT [dbo].[privileges] ([id], [action], [tablename]) VALUES (56, N'insert', N'master_customer')
INSERT [dbo].[privileges] ([id], [action], [tablename]) VALUES (57, N'update_or_delete', N'master_customer')
INSERT [dbo].[privileges] ([id], [action], [tablename]) VALUES (58, N'select', N'master_supplier')
INSERT [dbo].[privileges] ([id], [action], [tablename]) VALUES (59, N'insert', N'master_supplier')
INSERT [dbo].[privileges] ([id], [action], [tablename]) VALUES (60, N'update_or_delete', N'master_supplier')
INSERT [dbo].[privileges] ([id], [action], [tablename]) VALUES (61, N'select', N'master_user')
INSERT [dbo].[privileges] ([id], [action], [tablename]) VALUES (62, N'insert', N'master_user')
INSERT [dbo].[privileges] ([id], [action], [tablename]) VALUES (63, N'update_or_delete', N'master_user')
INSERT [dbo].[privileges] ([id], [action], [tablename]) VALUES (64, N'any', N'role')
INSERT [dbo].[privileges] ([id], [action], [tablename]) VALUES (65, N'insert', N'project')
INSERT [dbo].[privileges] ([id], [action], [tablename]) VALUES (67, N'finish_the_project', N'project')
INSERT [dbo].[privileges] ([id], [action], [tablename]) VALUES (68, N'update', N'project')
INSERT [dbo].[privileges] ([id], [action], [tablename]) VALUES (69, N'delete', N'project')
SET IDENTITY_INSERT [dbo].[privileges] OFF

INSERT [dbo].[role_privilege] ([roleid], [privilegeid]) VALUES (1, 1)
INSERT [dbo].[role_privilege] ([roleid], [privilegeid]) VALUES (1, 2)
INSERT [dbo].[role_privilege] ([roleid], [privilegeid]) VALUES (1, 5)
INSERT [dbo].[role_privilege] ([roleid], [privilegeid]) VALUES (1, 7)
INSERT [dbo].[role_privilege] ([roleid], [privilegeid]) VALUES (1, 9)
INSERT [dbo].[role_privilege] ([roleid], [privilegeid]) VALUES (1, 11)
INSERT [dbo].[role_privilege] ([roleid], [privilegeid]) VALUES (1, 12)
INSERT [dbo].[role_privilege] ([roleid], [privilegeid]) VALUES (1, 13)
INSERT [dbo].[role_privilege] ([roleid], [privilegeid]) VALUES (1, 15)
INSERT [dbo].[role_privilege] ([roleid], [privilegeid]) VALUES (1, 16)
INSERT [dbo].[role_privilege] ([roleid], [privilegeid]) VALUES (1, 17)
INSERT [dbo].[role_privilege] ([roleid], [privilegeid]) VALUES (1, 19)
INSERT [dbo].[role_privilege] ([roleid], [privilegeid]) VALUES (1, 20)
INSERT [dbo].[role_privilege] ([roleid], [privilegeid]) VALUES (1, 21)
INSERT [dbo].[role_privilege] ([roleid], [privilegeid]) VALUES (1, 23)
INSERT [dbo].[role_privilege] ([roleid], [privilegeid]) VALUES (1, 24)
INSERT [dbo].[role_privilege] ([roleid], [privilegeid]) VALUES (1, 25)
INSERT [dbo].[role_privilege] ([roleid], [privilegeid]) VALUES (1, 27)
INSERT [dbo].[role_privilege] ([roleid], [privilegeid]) VALUES (1, 28)
INSERT [dbo].[role_privilege] ([roleid], [privilegeid]) VALUES (1, 29)
INSERT [dbo].[role_privilege] ([roleid], [privilegeid]) VALUES (1, 31)
INSERT [dbo].[role_privilege] ([roleid], [privilegeid]) VALUES (1, 32)
INSERT [dbo].[role_privilege] ([roleid], [privilegeid]) VALUES (1, 33)
INSERT [dbo].[role_privilege] ([roleid], [privilegeid]) VALUES (1, 35)
INSERT [dbo].[role_privilege] ([roleid], [privilegeid]) VALUES (1, 36)
INSERT [dbo].[role_privilege] ([roleid], [privilegeid]) VALUES (1, 37)
INSERT [dbo].[role_privilege] ([roleid], [privilegeid]) VALUES (1, 39)
INSERT [dbo].[role_privilege] ([roleid], [privilegeid]) VALUES (1, 40)
INSERT [dbo].[role_privilege] ([roleid], [privilegeid]) VALUES (1, 41)
INSERT [dbo].[role_privilege] ([roleid], [privilegeid]) VALUES (1, 43)
INSERT [dbo].[role_privilege] ([roleid], [privilegeid]) VALUES (1, 44)
INSERT [dbo].[role_privilege] ([roleid], [privilegeid]) VALUES (1, 45)
INSERT [dbo].[role_privilege] ([roleid], [privilegeid]) VALUES (1, 47)
INSERT [dbo].[role_privilege] ([roleid], [privilegeid]) VALUES (1, 53)
INSERT [dbo].[role_privilege] ([roleid], [privilegeid]) VALUES (1, 54)
INSERT [dbo].[role_privilege] ([roleid], [privilegeid]) VALUES (1, 55)
INSERT [dbo].[role_privilege] ([roleid], [privilegeid]) VALUES (1, 56)
INSERT [dbo].[role_privilege] ([roleid], [privilegeid]) VALUES (1, 57)
INSERT [dbo].[role_privilege] ([roleid], [privilegeid]) VALUES (1, 58)
INSERT [dbo].[role_privilege] ([roleid], [privilegeid]) VALUES (1, 59)
INSERT [dbo].[role_privilege] ([roleid], [privilegeid]) VALUES (1, 60)
INSERT [dbo].[role_privilege] ([roleid], [privilegeid]) VALUES (1, 61)
INSERT [dbo].[role_privilege] ([roleid], [privilegeid]) VALUES (1, 62)
INSERT [dbo].[role_privilege] ([roleid], [privilegeid]) VALUES (1, 63)
INSERT [dbo].[role_privilege] ([roleid], [privilegeid]) VALUES (1, 64)
INSERT [dbo].[role_privilege] ([roleid], [privilegeid]) VALUES (1, 65)
INSERT [dbo].[role_privilege] ([roleid], [privilegeid]) VALUES (1, 67)
INSERT [dbo].[role_privilege] ([roleid], [privilegeid]) VALUES (1, 68)
INSERT [dbo].[role_privilege] ([roleid], [privilegeid]) VALUES (1, 69)
SET IDENTITY_INSERT [dbo].[roles] ON 

INSERT [dbo].[roles] ([id], [name], [description]) VALUES (1, N'admin', N'admin')
SET IDENTITY_INSERT [dbo].[roles] OFF
INSERT [dbo].[user_role] ([userid], [roleid]) VALUES (4, 1)
SET IDENTITY_INSERT [dbo].[users] ON 

INSERT [dbo].[users] ([id], [name], [username], [password], [description], [status]) VALUES (4, N'admin', N'admin', N'21232f297a57a5a743894a0e4a801fc3', N'a', 1)
SET IDENTITY_INSERT [dbo].[users] OFF
ALTER TABLE [dbo].[findprices] ADD  CONSTRAINT [DF_findprices_status]  DEFAULT ((0)) FOR [status]
GO
ALTER TABLE [dbo].[hpo] ADD  CONSTRAINT [DF_hpo_status]  DEFAULT ((0)) FOR [status]
GO
ALTER TABLE [dbo].[hpurchaseinvoice] ADD  CONSTRAINT [DF_hpurchaseinvoice_grandtotal]  DEFAULT ((0)) FOR [grandtotal]
GO
ALTER TABLE [dbo].[hpurchaseinvoice] ADD  CONSTRAINT [DF_hpurchaseinvoice_status]  DEFAULT ((0)) FOR [status]
GO
ALTER TABLE [dbo].[hsalesinvoice] ADD  CONSTRAINT [DF_hsalesinvoice_diskon]  DEFAULT ((0)) FOR [diskon]
GO
ALTER TABLE [dbo].[hsalesinvoice] ADD  CONSTRAINT [DF_hsalesinvoice_grandtotal]  DEFAULT ((0)) FOR [grandtotal]
GO
ALTER TABLE [dbo].[hsalesinvoice] ADD  CONSTRAINT [DF_hsalesinvoice_status]  DEFAULT ((0)) FOR [status]
GO
ALTER TABLE [dbo].[status] ADD  CONSTRAINT [DF_status_rfq]  DEFAULT ((0)) FOR [rfq]
GO
ALTER TABLE [dbo].[status] ADD  CONSTRAINT [DF_status_findprices]  DEFAULT ((0)) FOR [findprices]
GO
ALTER TABLE [dbo].[status] ADD  CONSTRAINT [DF_status_penawaran]  DEFAULT ((0)) FOR [penawaran]
GO
ALTER TABLE [dbo].[status] ADD  CONSTRAINT [DF_status_salesorder]  DEFAULT ((0)) FOR [salesorder]
GO
ALTER TABLE [dbo].[status] ADD  CONSTRAINT [DF_status_purchaseorder]  DEFAULT ((0)) FOR [purchaseorder]
GO
ALTER TABLE [dbo].[status] ADD  CONSTRAINT [DF_status_receiveitem]  DEFAULT ((0)) FOR [receiveitem]
GO
ALTER TABLE [dbo].[status] ADD  CONSTRAINT [DF_status_purchaseinvoice]  DEFAULT ((0)) FOR [purchaseinvoice]
GO
ALTER TABLE [dbo].[status] ADD  CONSTRAINT [DF_status_purchasepayment]  DEFAULT ((0)) FOR [purchasepayment]
GO
ALTER TABLE [dbo].[status] ADD  CONSTRAINT [DF_status_suratjalan]  DEFAULT ((0)) FOR [suratjalan]
GO
ALTER TABLE [dbo].[status] ADD  CONSTRAINT [DF_status_salesinvoice]  DEFAULT ((0)) FOR [salesinvoice]
GO
ALTER TABLE [dbo].[status] ADD  CONSTRAINT [DF_status_salespayment]  DEFAULT ((0)) FOR [salespayment]
GO
ALTER TABLE [dbo].[dpenawaran]  WITH CHECK ADD  CONSTRAINT [FK_dpenawaran_hpenawaran] FOREIGN KEY([penawaranid])
REFERENCES [dbo].[hpenawaran] ([id])
GO
ALTER TABLE [dbo].[dpenawaran] CHECK CONSTRAINT [FK_dpenawaran_hpenawaran]
GO
ALTER TABLE [dbo].[dpenawaran]  WITH CHECK ADD  CONSTRAINT [FK_dpenawaran_item_category] FOREIGN KEY([itemcategoryid])
REFERENCES [dbo].[item_category] ([id])
GO
ALTER TABLE [dbo].[dpenawaran] CHECK CONSTRAINT [FK_dpenawaran_item_category]
GO
ALTER TABLE [dbo].[dpenawaran]  WITH CHECK ADD  CONSTRAINT [FK_dpenawaran_suppliers] FOREIGN KEY([supplierid])
REFERENCES [dbo].[suppliers] ([id])
GO
ALTER TABLE [dbo].[dpenawaran] CHECK CONSTRAINT [FK_dpenawaran_suppliers]
GO
ALTER TABLE [dbo].[dpo]  WITH CHECK ADD  CONSTRAINT [FK_dpo_hpo] FOREIGN KEY([poid])
REFERENCES [dbo].[hpo] ([id])
GO
ALTER TABLE [dbo].[dpo] CHECK CONSTRAINT [FK_dpo_hpo]
GO
ALTER TABLE [dbo].[dpo]  WITH CHECK ADD  CONSTRAINT [FK_dpo_item_category] FOREIGN KEY([itemcategoryid])
REFERENCES [dbo].[item_category] ([id])
GO
ALTER TABLE [dbo].[dpo] CHECK CONSTRAINT [FK_dpo_item_category]
GO
ALTER TABLE [dbo].[dpurchaseinvoice]  WITH CHECK ADD  CONSTRAINT [FK_dpurchaseinvoice_dpurchaseinvoice] FOREIGN KEY([purchaseinvoiceid])
REFERENCES [dbo].[hpurchaseinvoice] ([id])
GO
ALTER TABLE [dbo].[dpurchaseinvoice] CHECK CONSTRAINT [FK_dpurchaseinvoice_dpurchaseinvoice]
GO
ALTER TABLE [dbo].[dpurchaseinvoice]  WITH CHECK ADD  CONSTRAINT [FK_dpurchaseinvoice_item_category] FOREIGN KEY([itemcategoryid])
REFERENCES [dbo].[item_category] ([id])
GO
ALTER TABLE [dbo].[dpurchaseinvoice] CHECK CONSTRAINT [FK_dpurchaseinvoice_item_category]
GO
ALTER TABLE [dbo].[dreceiveitem]  WITH CHECK ADD  CONSTRAINT [FK_dreceiveitem_hreceiveitem] FOREIGN KEY([receiveitemid])
REFERENCES [dbo].[hreceiveitem] ([id])
GO
ALTER TABLE [dbo].[dreceiveitem] CHECK CONSTRAINT [FK_dreceiveitem_hreceiveitem]
GO
ALTER TABLE [dbo].[dreceiveitem]  WITH CHECK ADD  CONSTRAINT [FK_dreceiveitem_item_category] FOREIGN KEY([itemcategoryid])
REFERENCES [dbo].[item_category] ([id])
GO
ALTER TABLE [dbo].[dreceiveitem] CHECK CONSTRAINT [FK_dreceiveitem_item_category]
GO
ALTER TABLE [dbo].[drfq]  WITH CHECK ADD  CONSTRAINT [FK_drfq_hrfq] FOREIGN KEY([rfqid])
REFERENCES [dbo].[hrfq] ([id])
GO
ALTER TABLE [dbo].[drfq] CHECK CONSTRAINT [FK_drfq_hrfq]
GO
ALTER TABLE [dbo].[drfq]  WITH CHECK ADD  CONSTRAINT [FK_drfq_item_category] FOREIGN KEY([itemcategoryid])
REFERENCES [dbo].[item_category] ([id])
GO
ALTER TABLE [dbo].[drfq] CHECK CONSTRAINT [FK_drfq_item_category]
GO
ALTER TABLE [dbo].[dsalesinvoice]  WITH CHECK ADD  CONSTRAINT [FK_dsalesinvoice_hsalesinvoice] FOREIGN KEY([salesinvoiceid])
REFERENCES [dbo].[hsalesinvoice] ([id])
GO
ALTER TABLE [dbo].[dsalesinvoice] CHECK CONSTRAINT [FK_dsalesinvoice_hsalesinvoice]
GO
ALTER TABLE [dbo].[dsalesinvoice]  WITH CHECK ADD  CONSTRAINT [FK_dsalesinvoice_item_category] FOREIGN KEY([itemcategoryid])
REFERENCES [dbo].[item_category] ([id])
GO
ALTER TABLE [dbo].[dsalesinvoice] CHECK CONSTRAINT [FK_dsalesinvoice_item_category]
GO
ALTER TABLE [dbo].[dsalesorder]  WITH CHECK ADD  CONSTRAINT [FK_dsalesorder_hsalesorder] FOREIGN KEY([salesorderid])
REFERENCES [dbo].[hsalesorder] ([id])
GO
ALTER TABLE [dbo].[dsalesorder] CHECK CONSTRAINT [FK_dsalesorder_hsalesorder]
GO
ALTER TABLE [dbo].[dsalesorder]  WITH CHECK ADD  CONSTRAINT [FK_dsalesorder_item_category] FOREIGN KEY([itemcategoryid])
REFERENCES [dbo].[item_category] ([id])
GO
ALTER TABLE [dbo].[dsalesorder] CHECK CONSTRAINT [FK_dsalesorder_item_category]
GO
ALTER TABLE [dbo].[dsuratjalan]  WITH CHECK ADD  CONSTRAINT [FK_dsuratjalan_hsuratjalan] FOREIGN KEY([suratjalanid])
REFERENCES [dbo].[hsuratjalan] ([id])
GO
ALTER TABLE [dbo].[dsuratjalan] CHECK CONSTRAINT [FK_dsuratjalan_hsuratjalan]
GO
ALTER TABLE [dbo].[dsuratjalan]  WITH CHECK ADD  CONSTRAINT [FK_dsuratjalan_item_category] FOREIGN KEY([itemcategoryid])
REFERENCES [dbo].[item_category] ([id])
GO
ALTER TABLE [dbo].[dsuratjalan] CHECK CONSTRAINT [FK_dsuratjalan_item_category]
GO
ALTER TABLE [dbo].[findprices]  WITH CHECK ADD  CONSTRAINT [FK_findprices_item_category] FOREIGN KEY([itemcategoryid])
REFERENCES [dbo].[item_category] ([id])
GO
ALTER TABLE [dbo].[findprices] CHECK CONSTRAINT [FK_findprices_item_category]
GO
ALTER TABLE [dbo].[findprices]  WITH CHECK ADD  CONSTRAINT [FK_findprices_projects1] FOREIGN KEY([projectid])
REFERENCES [dbo].[projects] ([id])
GO
ALTER TABLE [dbo].[findprices] CHECK CONSTRAINT [FK_findprices_projects1]
GO
ALTER TABLE [dbo].[findprices]  WITH CHECK ADD  CONSTRAINT [FK_findprices_supplier] FOREIGN KEY([supplierid])
REFERENCES [dbo].[suppliers] ([id])
GO
ALTER TABLE [dbo].[findprices] CHECK CONSTRAINT [FK_findprices_supplier]
GO
ALTER TABLE [dbo].[findpricesnote]  WITH CHECK ADD  CONSTRAINT [FK_findpricesnote_projects] FOREIGN KEY([projectid])
REFERENCES [dbo].[projects] ([id])
GO
ALTER TABLE [dbo].[findpricesnote] CHECK CONSTRAINT [FK_findpricesnote_projects]
GO
ALTER TABLE [dbo].[hpenawaran]  WITH CHECK ADD  CONSTRAINT [FK_hpenawaran_customers] FOREIGN KEY([customerid])
REFERENCES [dbo].[customers] ([id])
GO
ALTER TABLE [dbo].[hpenawaran] CHECK CONSTRAINT [FK_hpenawaran_customers]
GO
ALTER TABLE [dbo].[hpenawaran]  WITH CHECK ADD  CONSTRAINT [FK_hpenawaran_projects1] FOREIGN KEY([projectid])
REFERENCES [dbo].[projects] ([id])
GO
ALTER TABLE [dbo].[hpenawaran] CHECK CONSTRAINT [FK_hpenawaran_projects1]
GO
ALTER TABLE [dbo].[hpo]  WITH CHECK ADD  CONSTRAINT [FK_hpo_projects] FOREIGN KEY([projectid])
REFERENCES [dbo].[projects] ([id])
GO
ALTER TABLE [dbo].[hpo] CHECK CONSTRAINT [FK_hpo_projects]
GO
ALTER TABLE [dbo].[hpo]  WITH CHECK ADD  CONSTRAINT [FK_hpo_suppliers] FOREIGN KEY([supplierid])
REFERENCES [dbo].[suppliers] ([id])
GO
ALTER TABLE [dbo].[hpo] CHECK CONSTRAINT [FK_hpo_suppliers]
GO
ALTER TABLE [dbo].[hpurchaseinvoice]  WITH CHECK ADD  CONSTRAINT [FK_purchaseinvoice_hpo] FOREIGN KEY([poid])
REFERENCES [dbo].[hpo] ([id])
GO
ALTER TABLE [dbo].[hpurchaseinvoice] CHECK CONSTRAINT [FK_purchaseinvoice_hpo]
GO
ALTER TABLE [dbo].[hpurchaseinvoice]  WITH CHECK ADD  CONSTRAINT [FK_purchaseinvoice_projects] FOREIGN KEY([projectid])
REFERENCES [dbo].[projects] ([id])
GO
ALTER TABLE [dbo].[hpurchaseinvoice] CHECK CONSTRAINT [FK_purchaseinvoice_projects]
GO
ALTER TABLE [dbo].[hpurchaseinvoice]  WITH CHECK ADD  CONSTRAINT [FK_purchaseinvoice_suppliers] FOREIGN KEY([supplierid])
REFERENCES [dbo].[suppliers] ([id])
GO
ALTER TABLE [dbo].[hpurchaseinvoice] CHECK CONSTRAINT [FK_purchaseinvoice_suppliers]
GO
ALTER TABLE [dbo].[hreceiveitem]  WITH CHECK ADD  CONSTRAINT [FK_hreceiveitem_hpo] FOREIGN KEY([poid])
REFERENCES [dbo].[hpo] ([id])
GO
ALTER TABLE [dbo].[hreceiveitem] CHECK CONSTRAINT [FK_hreceiveitem_hpo]
GO
ALTER TABLE [dbo].[hreceiveitem]  WITH CHECK ADD  CONSTRAINT [FK_hreceiveitem_projects] FOREIGN KEY([projectid])
REFERENCES [dbo].[projects] ([id])
GO
ALTER TABLE [dbo].[hreceiveitem] CHECK CONSTRAINT [FK_hreceiveitem_projects]
GO
ALTER TABLE [dbo].[hreceiveitem]  WITH CHECK ADD  CONSTRAINT [FK_hreceiveitem_suppliers] FOREIGN KEY([supplierid])
REFERENCES [dbo].[suppliers] ([id])
GO
ALTER TABLE [dbo].[hreceiveitem] CHECK CONSTRAINT [FK_hreceiveitem_suppliers]
GO
ALTER TABLE [dbo].[hrfq]  WITH CHECK ADD  CONSTRAINT [FK_hrfq_customers] FOREIGN KEY([customerid])
REFERENCES [dbo].[customers] ([id])
GO
ALTER TABLE [dbo].[hrfq] CHECK CONSTRAINT [FK_hrfq_customers]
GO
ALTER TABLE [dbo].[hrfq]  WITH CHECK ADD  CONSTRAINT [FK_hrfq_projects] FOREIGN KEY([projectid])
REFERENCES [dbo].[projects] ([id])
GO
ALTER TABLE [dbo].[hrfq] CHECK CONSTRAINT [FK_hrfq_projects]
GO
ALTER TABLE [dbo].[hsalesinvoice]  WITH CHECK ADD  CONSTRAINT [FK_hsalesinvoice_customers] FOREIGN KEY([customerid])
REFERENCES [dbo].[customers] ([id])
GO
ALTER TABLE [dbo].[hsalesinvoice] CHECK CONSTRAINT [FK_hsalesinvoice_customers]
GO
ALTER TABLE [dbo].[hsalesinvoice]  WITH CHECK ADD  CONSTRAINT [FK_hsalesinvoice_projects] FOREIGN KEY([projectid])
REFERENCES [dbo].[projects] ([id])
GO
ALTER TABLE [dbo].[hsalesinvoice] CHECK CONSTRAINT [FK_hsalesinvoice_projects]
GO
ALTER TABLE [dbo].[hsalesorder]  WITH CHECK ADD  CONSTRAINT [FK_hsalesorder_customers] FOREIGN KEY([customerid])
REFERENCES [dbo].[customers] ([id])
GO
ALTER TABLE [dbo].[hsalesorder] CHECK CONSTRAINT [FK_hsalesorder_customers]
GO
ALTER TABLE [dbo].[hsalesorder]  WITH CHECK ADD  CONSTRAINT [FK_hsalesorder_projects] FOREIGN KEY([projectid])
REFERENCES [dbo].[projects] ([id])
GO
ALTER TABLE [dbo].[hsalesorder] CHECK CONSTRAINT [FK_hsalesorder_projects]
GO
ALTER TABLE [dbo].[hsuratjalan]  WITH CHECK ADD  CONSTRAINT [FK_hsuratjalan_projects] FOREIGN KEY([projectid])
REFERENCES [dbo].[projects] ([id])
GO
ALTER TABLE [dbo].[hsuratjalan] CHECK CONSTRAINT [FK_hsuratjalan_projects]
GO
ALTER TABLE [dbo].[penawarannote]  WITH CHECK ADD  CONSTRAINT [FK_penawarannote_projects] FOREIGN KEY([projectid])
REFERENCES [dbo].[projects] ([id])
GO
ALTER TABLE [dbo].[penawarannote] CHECK CONSTRAINT [FK_penawarannote_projects]
GO
ALTER TABLE [dbo].[ponote]  WITH CHECK ADD  CONSTRAINT [FK_ponote_projects] FOREIGN KEY([projectid])
REFERENCES [dbo].[projects] ([id])
GO
ALTER TABLE [dbo].[ponote] CHECK CONSTRAINT [FK_ponote_projects]
GO
ALTER TABLE [dbo].[projects]  WITH CHECK ADD  CONSTRAINT [FK_projects_customers] FOREIGN KEY([customerid])
REFERENCES [dbo].[customers] ([id])
GO
ALTER TABLE [dbo].[projects] CHECK CONSTRAINT [FK_projects_customers]
GO
ALTER TABLE [dbo].[projects]  WITH CHECK ADD  CONSTRAINT [FK_projects_status] FOREIGN KEY([statusid])
REFERENCES [dbo].[status] ([id])
GO
ALTER TABLE [dbo].[projects] CHECK CONSTRAINT [FK_projects_status]
GO
ALTER TABLE [dbo].[purchaseinvoicenote]  WITH CHECK ADD  CONSTRAINT [FK_purchaseinvoicenote_projects] FOREIGN KEY([projectid])
REFERENCES [dbo].[projects] ([id])
GO
ALTER TABLE [dbo].[purchaseinvoicenote] CHECK CONSTRAINT [FK_purchaseinvoicenote_projects]
GO
ALTER TABLE [dbo].[purchasepayment]  WITH CHECK ADD  CONSTRAINT [FK_hpurchasepayment_hpurchaseinvoice] FOREIGN KEY([purchaseinvoiceid])
REFERENCES [dbo].[hpurchaseinvoice] ([id])
GO
ALTER TABLE [dbo].[purchasepayment] CHECK CONSTRAINT [FK_hpurchasepayment_hpurchaseinvoice]
GO
ALTER TABLE [dbo].[purchasepayment]  WITH CHECK ADD  CONSTRAINT [FK_hpurchasepayment_projects] FOREIGN KEY([projectid])
REFERENCES [dbo].[projects] ([id])
GO
ALTER TABLE [dbo].[purchasepayment] CHECK CONSTRAINT [FK_hpurchasepayment_projects]
GO
ALTER TABLE [dbo].[purchasepayment]  WITH CHECK ADD  CONSTRAINT [FK_hpurchasepayment_suppliers] FOREIGN KEY([supplierid])
REFERENCES [dbo].[suppliers] ([id])
GO
ALTER TABLE [dbo].[purchasepayment] CHECK CONSTRAINT [FK_hpurchasepayment_suppliers]
GO
ALTER TABLE [dbo].[purchasepaymentnote]  WITH CHECK ADD  CONSTRAINT [FK_purchasepaymentnote_projects] FOREIGN KEY([projectid])
REFERENCES [dbo].[projects] ([id])
GO
ALTER TABLE [dbo].[purchasepaymentnote] CHECK CONSTRAINT [FK_purchasepaymentnote_projects]
GO
ALTER TABLE [dbo].[receiveitemnote]  WITH CHECK ADD  CONSTRAINT [FK_receiveitemnote_projects] FOREIGN KEY([projectid])
REFERENCES [dbo].[projects] ([id])
GO
ALTER TABLE [dbo].[receiveitemnote] CHECK CONSTRAINT [FK_receiveitemnote_projects]
GO
ALTER TABLE [dbo].[rfqnote]  WITH CHECK ADD  CONSTRAINT [FK_rfqnote_projects] FOREIGN KEY([projectid])
REFERENCES [dbo].[projects] ([id])
GO
ALTER TABLE [dbo].[rfqnote] CHECK CONSTRAINT [FK_rfqnote_projects]
GO
ALTER TABLE [dbo].[role_privilege]  WITH CHECK ADD  CONSTRAINT [FK_role_privilege_privilege] FOREIGN KEY([privilegeid])
REFERENCES [dbo].[privileges] ([id])
GO
ALTER TABLE [dbo].[role_privilege] CHECK CONSTRAINT [FK_role_privilege_privilege]
GO
ALTER TABLE [dbo].[role_privilege]  WITH CHECK ADD  CONSTRAINT [FK_role_privilege_roles] FOREIGN KEY([roleid])
REFERENCES [dbo].[roles] ([id])
GO
ALTER TABLE [dbo].[role_privilege] CHECK CONSTRAINT [FK_role_privilege_roles]
GO
ALTER TABLE [dbo].[salesinvoicenote]  WITH CHECK ADD  CONSTRAINT [FK_salesinvoicenote_projects] FOREIGN KEY([projectid])
REFERENCES [dbo].[projects] ([id])
GO
ALTER TABLE [dbo].[salesinvoicenote] CHECK CONSTRAINT [FK_salesinvoicenote_projects]
GO
ALTER TABLE [dbo].[salesordernote]  WITH CHECK ADD  CONSTRAINT [FK_salesordernote_projects] FOREIGN KEY([projectid])
REFERENCES [dbo].[projects] ([id])
GO
ALTER TABLE [dbo].[salesordernote] CHECK CONSTRAINT [FK_salesordernote_projects]
GO
ALTER TABLE [dbo].[salespayment]  WITH CHECK ADD  CONSTRAINT [FK_hsalespayment_projects] FOREIGN KEY([projectid])
REFERENCES [dbo].[projects] ([id])
GO
ALTER TABLE [dbo].[salespayment] CHECK CONSTRAINT [FK_hsalespayment_projects]
GO
ALTER TABLE [dbo].[salespayment]  WITH CHECK ADD  CONSTRAINT [FK_salespayment_hsalesinvoice] FOREIGN KEY([salesinvoiceid])
REFERENCES [dbo].[hsalesinvoice] ([id])
GO
ALTER TABLE [dbo].[salespayment] CHECK CONSTRAINT [FK_salespayment_hsalesinvoice]
GO
ALTER TABLE [dbo].[salespaymentnote]  WITH CHECK ADD  CONSTRAINT [FK_salespaymentnote_projects] FOREIGN KEY([projectid])
REFERENCES [dbo].[projects] ([id])
GO
ALTER TABLE [dbo].[salespaymentnote] CHECK CONSTRAINT [FK_salespaymentnote_projects]
GO
ALTER TABLE [dbo].[suratjalannote]  WITH CHECK ADD  CONSTRAINT [FK_suratjalannote_projects] FOREIGN KEY([projectid])
REFERENCES [dbo].[projects] ([id])
GO
ALTER TABLE [dbo].[suratjalannote] CHECK CONSTRAINT [FK_suratjalannote_projects]
GO
ALTER TABLE [dbo].[user_role]  WITH CHECK ADD  CONSTRAINT [FK_user_role_roles] FOREIGN KEY([roleid])
REFERENCES [dbo].[roles] ([id])
GO
ALTER TABLE [dbo].[user_role] CHECK CONSTRAINT [FK_user_role_roles]
GO
ALTER TABLE [dbo].[user_role]  WITH CHECK ADD  CONSTRAINT [FK_user_role_users] FOREIGN KEY([userid])
REFERENCES [dbo].[users] ([id])
GO
ALTER TABLE [dbo].[user_role] CHECK CONSTRAINT [FK_user_role_users]
GO
USE [master]
GO
ALTER DATABASE [dbsms] SET  READ_WRITE 
GO
