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
	prjNo			int		NOT NULL,
    prjLeader		int,
    description		varchar(255),
    dueDate			date,
    deliverables	varchar(255),
    hoursNeeded		int,
    prjStatus		varchar(255),
    primary key(prjNo),
    foreign key (prjLeader) references Employee (employeeID));
    
create table WorksOn (
	employeeID		int		NOT NULL,
    prjNo			int		NOT NULL,
    primary key(employeeID, prjNo),
    foreign key(employeeID) references Employee(employeeID),
    foreign key(prjNo) references Project(prjNo));
    
create table Notes (
	employeeID		int		NOT NULL,
    prjNo			int		NOT NULL,
    notes			varchar(255),
    primary key(employeeID, prjNo),
    foreign key(employeeID) references Employee(employeeID),
    foreign key(prjNo) references Project(prjNo));
    
create table Vacation (
	employeeID		int		NOT NULL,
    startDate		date,
    endDate			date,
    primary key(employeeID),
    foreign key(employeeID) references Employee(employeeID));
    
    
