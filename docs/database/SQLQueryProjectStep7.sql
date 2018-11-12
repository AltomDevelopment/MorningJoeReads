use ClassProject;

Drop table if exists dbo.Users;

Create table dbo.Users
(
	userid		 bigint		  not null,
	pword		 bigint		  not null,
	firstname	 varchar(50)  not null,
	lastname	 varchar(50)  not null,
	emailaddress varchar(100) not null
);

Drop table if exists dbo.Searches;

Create table dbo.Searches
(	
	userid		bigint		 not null,
	searchid    bigint		 not null,
	searchtext  varchar(100) not null,
	datecreated datetime	 not null,
	timesviewed int			 not null,
	Constraint PK_Searches
		primary key(userid)
);

Drop table if exists dbo.Articles

Create table dbo.Articles
(
	userid bigint not null,
	articleid bigint not null,
	website varchar(100) not null,
	datesaved datetime not null,
	Constraint PK_Articles 
		primary key(userid)
);

select * from Users;
select * from Searches;
select * from Articles;
		
