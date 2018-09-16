
/*==============================================================*/
/* Meetings Notes1: Sql Server database creation script  */
/*==============================================================*/


/*==============================================================*/
/* Table: Category                                              */
/*==============================================================*/
create table Category (
   CategoryId           int                  identity,
   CategoryName         varchar(15)          not null,
   Description          varchar(100)         not null,
   constraint PK_CATEGORY primary key  (CategoryId)
)
go


/*==============================================================*/
/* Index: CategoryName                                          */
/*==============================================================*/
create unique  index CategoryName on Category (
CategoryName
)
go


/*==============================================================*/
/* Index: PrimaryKey                                            */
/*==============================================================*/
create unique  index PrimaryKey on Category (
CategoryId
)
go


/*==============================================================*/
/* Table: Member                                              */
/*==============================================================*/
create table [Member] (
   MemberId             int                  identity,
   Email                varchar(100)         not null,
   CompanyName          varchar(40)          not null,
   City                 varchar(15)          not null,
   Country              varchar(15)          not null,
   constraint PK_MEMBER primary key  (MemberId)
)
go


/*==============================================================*/
/* Index: PrimaryKey                                            */
/*==============================================================*/
create unique  index PrimaryKey on Member (
MemberId
)
go


/*==============================================================*/
/* Index: MemberEmailIdx                                      */
/*==============================================================*/
create unique  index MemberEmailIdx on [Member] (
Email
)
go


/*==============================================================*/
/* Table: [Order]                                               */
/*==============================================================*/
create table [Order] (
   OrderId              int                  identity,
   MemberId             int                  not null,
   OrderDate            datetime             not null,
   RequiredDate         datetime             null,
   ShippedDate          datetime             null,
   Freight              money                null,
   constraint PK_ORDER primary key  (OrderId)
)
go


/*==============================================================*/
/* Index: PrimaryKey                                            */
/*==============================================================*/
create unique  index PrimaryKey on [Order] (
OrderId
)
go


/*==============================================================*/
/* Index: OrderMemberIdx                                      */
/*==============================================================*/
create   index OrderMemberIdx on [Order] (
MemberId
)
go


/*==============================================================*/
/* Table: OrderDetail                                           */
/*==============================================================*/
create table OrderDetail (
   OrderId              int                  not null,
   ProductId            int                  not null,
   UnitPrice            money                not null,
   Quantity             int                  not null,
   Discount             float                not null,
   constraint PK_ORDERDETAIL primary key  (OrderId, ProductId)
)
go


/*==============================================================*/
/* Index: PrimaryKey                                            */
/*==============================================================*/
create unique  index PrimaryKey on OrderDetail (
OrderId,
ProductId
)
go


/*==============================================================*/
/* Index: OrderID                                               */
/*==============================================================*/
create   index OrderID on OrderDetail (
OrderId
)
go


/*==============================================================*/
/* Index: ProductID                                             */
/*==============================================================*/
create   index ProductID on OrderDetail (
ProductId
)
go


/*==============================================================*/
/* Index: "ProductsOrder Details"                               */
/*==============================================================*/
create   index [ProductsOrder Details] on OrderDetail (
ProductId
)
go


/*==============================================================*/
/* Table: Product                                               */
/*==============================================================*/
create table [Product] (
   ProductId            int                  identity,
   CategoryId           int                  not null,
   ProductName          varchar(40)          not null,
   Weight               varchar(20)          not null,
   UnitPrice            money                not null,
   UnitsInStock         int                  not null,
   constraint PK_PRODUCT primary key  (ProductId)
)
go


/*==============================================================*/
/* Index: PrimaryKey                                            */
/*==============================================================*/
create unique  index PrimaryKey on Product (
ProductId
)
go


/*==============================================================*/
/* Index: CategoriesProducts                                    */
/*==============================================================*/
create   index CategoriesProducts on Product (
CategoryId
)
go


/*==============================================================*/
/* Index: CategoryID                                            */
/*==============================================================*/
create   index CategoryID on Product (
CategoryId
)
go


/*==============================================================*/
/* Index: ProductName                                           */
/*==============================================================*/
create   index ProductName on Product (
ProductName
)
go


alter table [Order]
   add constraint FK_ORDER_REFERENCE_MEMBER foreign key (MemberId)
      references Member (MemberId)
go


alter table OrderDetail
   add constraint FK_ORDERDET_REFERENCE_ORDER foreign key (OrderId)
      references [Order] (OrderId)
go


alter table OrderDetail
   add constraint FK_ORDERDET_REFERENCE_PRODUCT foreign key (ProductId)
      references Product (ProductId)
go


alter table Product
   add constraint FK_PRODUCT_REFERENCE_CATEGORY foreign key (CategoryId)
      references Category (CategoryId)
go


-- and now for the data
