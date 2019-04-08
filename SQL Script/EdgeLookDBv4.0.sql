create table Employee (
	employeeID		int		NOT NULL,
    fname			varchar(30),
	lname			varchar(30),
    email			varchar(50),
    pssword			varchar(50),
    phone			varchar(50),
    hoursAvail		int,
    primary key(employeeID));
    
create table Project (
	prjNo			varchar(30)		NOT NULL,
    prjLeader		int,
    description		varchar(255),
    prjPhase		varchar(30),
    dueDate			varchar(30),
    deliverables	varchar(255),
    hoursNeeded		int,
    prjStatus		varchar(255),
    primary key(prjNo),
    foreign key (prjLeader) references Employee (employeeID));
    
create table WorksOn (
	employeeID		int		NOT NULL,
    prjNo			varchar(30)		NOT NULL,
	hours			int,
    primary key(employeeID, prjNo),
    foreign key(employeeID) references Employee(employeeID),
    foreign key(prjNo) references Project(prjNo));
    
create table Notes (
	employeeID		int		NOT NULL,
    prjNo			varchar(30)		NOT NULL,
	nDate			varchar(30)		NOT NULL,
    notes			varchar(255),
    primary key(employeeID, prjNo, nDate),
    foreign key(employeeID) references Employee(employeeID),
    foreign key(prjNo) references Project(prjNo));
    
create table Vacation (
	employeeID		int		NOT NULL,
    startDate		date,
    endDate			date,
    primary key(employeeID),
    foreign key(employeeID) references Employee(employeeID));
    
 insert into Employee
 values(322,'Chris','Williams','cwilliams@gmail.com','******','322-678-9821',20);
 
 insert into Employee
 values(425,'Iris','Ivy','iris@yahoo.com','******','567-111-5675',12);
 
 insert into Employee
 values(222,'Rose','Jones','rosej@sbcglobal.net','******','565-221-8900',3);
 
 insert into Project
 values('E349',322,'Rocklin ES # 12','CD','Monday, November 18, 2019','100% CD',8,'Need Revit help.');
 
 insert into Project
 values('F391',425,'Gait HS','CD','Wednesday, November 20, 2019','50% CD',8,'11/29 specs done');
 
 insert into Project
 values('F163',322,'Leimbach ES','CD','Saturday, December 28, 2019','50% CD',24,'Need to make a site visit');
 
 
 insert into WorksOn
 values(222,'E349',10);
 
 insert into WorksOn
 values(222,'F163',12);
 
 insert into WorksOn
 values(425,'F391',12);
 
 insert into WorksOn
 values(322,'E349',13);
 
 insert into WorksOn
 values(322,'F163',14);
 
 insert into Vacation
 values(322,'2019-06-11','2019-06-15');
 
 insert into Notes
 values(425,'E349','Project needs this and this');
 
 insert into Notes
 values(322,'F163','Project needs this and that');