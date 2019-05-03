create table Employee (
	employeeID varchar(11) NOT NULL,
    fname varchar(30),
	lname varchar(30),
    email varchar(50),
    pssword varchar(50),
    phone varchar(50),
    hoursAvail int,
	admin boolean,
	active boolean,
    primary key(employeeID));
    
create table Project (
	prjNo varchar(30) NOT NULL,
    prjLeader varchar(11),
    description varchar(255),
    deliverables varchar(255),
    hoursNeeded int,
	prjComplete boolean,
    primary key(prjNo),
    foreign key (prjLeader) references Employee (employeeID));
    
create table WorksOn (
	employeeID varchar(11) NOT NULL,
    prjNo varchar(30) NOT NULL,
	hours int,
    primary key(employeeID, prjNo),
    foreign key(employeeID) references Employee(employeeID),
    foreign key(prjNo) references Project(prjNo));
	
create table ProjectPhase (
	prjNo varchar(30) NOT NULL,
	prjPhase varchar(30) NOT NULL,
	phaseDueDate date,
	status varchar(255),
	primary key(prjNo, prjPhase),
	foreign key(prjNo) references Project(prjNo));
    
create table Notes (
	employeeID varchar(11) NOT NULL,
    prjNo varchar(30) NOT NULL,
	nDate varchar(30) NOT NULL,
    notes varchar(255),
    primary key(employeeID, prjNo, nDate),
    foreign key(employeeID) references Employee(employeeID),
    foreign key(prjNo) references Project(prjNo));
    
create table Vacation (
	employeeID varchar(11) NOT NULL,
    startDate date NOT NULL,
    endDate date,
    primary key(employeeID, startDate),
    foreign key(employeeID) references Employee(employeeID));
	
insert into Employee values("1", "Admin","Admin","admin@gmail.com","password","111-111-1111",0,1,1);
    
 