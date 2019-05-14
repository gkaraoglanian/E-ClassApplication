CREATE TABLE "User" (
	"registrationNumber" varchar(10) NOT NULL,
	"password" varchar(50) NOT NULL,
	"name" varchar(30) NOT NULL,
	"surname" varchar(30) NOT NULL,
	"email" varchar(70) NOT NULL,
	CONSTRAINT User_pk PRIMARY KEY ("registrationNumber")
) WITH (
  OIDS=FALSE
);



CREATE TABLE "Professor" (
	"registrationNumber" varchar(10) NOT NULL,
	"id_course" varchar(10) NOT NULL
) WITH (
  OIDS=FALSE
);



CREATE TABLE "Course" (
	"id_course" varchar(10) NOT NULL,
	"project" varchar(10) NOT NULL,
	CONSTRAINT Course_pk PRIMARY KEY ("id_course")
) WITH (
  OIDS=FALSE
);



CREATE TABLE "Project" (
	"id_project" varchar(10) NOT NULL,
	"grade" integer(2) NOT NULL,
	"uploaded_file" BINARY NOT NULL,
	CONSTRAINT Project_pk PRIMARY KEY ("id_project")
) WITH (
  OIDS=FALSE
);



CREATE TABLE "Team" (
	"id_team" varchar(10) NOT NULL,
	"course" varchar(10) NOT NULL,
	"student1" varchar(10) NOT NULL,
	"student2" varchar(10) NOT NULL,
	"student3" varchar(10) NOT NULL,
	"student4" varchar(10) NOT NULL,
	"student5" varchar(10) NOT NULL,
	CONSTRAINT Team_pk PRIMARY KEY ("id_team")
) WITH (
  OIDS=FALSE
);



CREATE TABLE "Student" (
	"registrationNumber" varchar(10) NOT NULL
) WITH (
  OIDS=FALSE
);



CREATE TABLE "Admin" (
	"registrationNumber" varchar(10) NOT NULL
) WITH (
  OIDS=FALSE
);




ALTER TABLE "Professor" ADD CONSTRAINT "Professor_fk0" FOREIGN KEY ("registrationNumber") REFERENCES "User"("registrationNumber");
ALTER TABLE "Professor" ADD CONSTRAINT "Professor_fk1" FOREIGN KEY ("id_course") REFERENCES "Course"("id_course");

ALTER TABLE "Course" ADD CONSTRAINT "Course_fk0" FOREIGN KEY ("project") REFERENCES "Project"("id_project");


ALTER TABLE "Team" ADD CONSTRAINT "Team_fk0" FOREIGN KEY ("course") REFERENCES "Course"("id_course");
ALTER TABLE "Team" ADD CONSTRAINT "Team_fk1" FOREIGN KEY ("student1") REFERENCES "Student"("registrationNumber");
ALTER TABLE "Team" ADD CONSTRAINT "Team_fk2" FOREIGN KEY ("student2") REFERENCES "Student"("registrationNumber");
ALTER TABLE "Team" ADD CONSTRAINT "Team_fk3" FOREIGN KEY ("student3") REFERENCES "Student"("registrationNumber");
ALTER TABLE "Team" ADD CONSTRAINT "Team_fk4" FOREIGN KEY ("student4") REFERENCES "Student"("registrationNumber");
ALTER TABLE "Team" ADD CONSTRAINT "Team_fk5" FOREIGN KEY ("student5") REFERENCES "Student"("registrationNumber");

ALTER TABLE "Student" ADD CONSTRAINT "Student_fk0" FOREIGN KEY ("registrationNumber") REFERENCES "User"("registrationNumber");

ALTER TABLE "Admin" ADD CONSTRAINT "Admin_fk0" FOREIGN KEY ("registrationNumber") REFERENCES "User"("registrationNumber");

