create table Employee (
	employeeID int NOT NULL,
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
    prjLeader int,
    description varchar(255),
    deliverables varchar(255),
    hoursNeeded int,
	prjComplete boolean,
    primary key(prjNo),
    foreign key (prjLeader) references Employee (employeeID));
    
create table WorksOn (
	employeeID int NOT NULL,
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
	employeeID int NOT NULL,
    prjNo varchar(30) NOT NULL,
	nDate varchar(30) NOT NULL,
    notes varchar(255),
    primary key(employeeID, prjNo, nDate),
    foreign key(employeeID) references Employee(employeeID),
    foreign key(prjNo) references Project(prjNo));
    
create table Vacation (
	employeeID int NOT NULL,
    startDate date NOT NULL,
    endDate date,
    primary key(employeeID, startDate),
    foreign key(employeeID) references Employee(employeeID)); public void ListVacations(DataGridView vacationGrid)
        {
            conn.Open();
            MySqlDataAdapter da = new MySqlDataAdapter("Select startDate, endDate from Vacation where employeeID = '" + this.eID + "';", conn);
            DataTable table = new DataTable();
            da.Fill(table);
            vacationGrid.DataSource = table;
            conn.Close();
        }
    
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
 
 insert into ProjectPhase
 values('F163','CD','2019-06-11','Site visits');
 
 
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
 
 /* Below is for Johanna's use only */
 
 alter table Project
 add prjComplete boolean;
 
 alter table Project
 drop prjPhase;
 
 alter table Project
 drop dueDate;
 
 alter table Project
 drop prjStatus;
 
 alter table Employee
 add admin boolean;
 
 alter table Employee
 add active boolean;
 
 update Employee
 set admin = 0
 where employeeID = 322;
 
 update Employee
 set admin = 1
 where employeeID = 425;
 
 update Employee
 set admin = 0
 where employeeID = 222;
 
 update Project
 set prjComplete = 0
 where prjNo = 'A123';
 
 update Project
 set prjComplete = 0
 where prjNo = 'A899';
 
 update Project
 set prjComplete = 0
 where prjNo = 'B64';
 
 update Project
 set prjComplete = 1
 where prjNo = 'E349';
 
 update Employee
 set active = 1
 where employeeID = 0;
 
  update Employee
 set active = 1
 where employeeID = 123;
 
  update Employee
 set active = 1
 where employeeID = 222;
 
  update Employee
 set active = 1
 where employeeID = 322;
 
  update Employee
 set active = 1
 where employeeID = 420;
 
  update Employee
 set active = 1
 where employeeID = 425;
 
 insert into ProjectPhase
 values('F163','CC','2019-06-11','Site visits');
 
  update Project
 set prjComplete = 0
 where prjNo = 'F163';
 
 select E.fname, P.prjNo, P.description, PP.prjPhase, PP.phaseDueDate, P.deliverables, P.hoursNeeded, PP.status
 from Employee E, Project P, ProjectPhase PP
 where P.prjLeader = E.employeeID AND P.prjNo = PP.prjNo AND P.prjComplete = 0;
 
 