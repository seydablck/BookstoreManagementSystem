# BookstoreManagementSystem

NOTE:

THE GOAL OF PROJECT

The main purpose of designing a bookstore management application is to develop a system that enables the recording, 
altering, showing and managing of products such as books, movies, music and their attributes, staff, customer, 
payment information and their attributes, together with their relationships with each other. 
This database management application will significantly contribute to the knowledge and culture level of the society by providing easier access to products, 
not only ensuring that staff, products, customers and their payment information can be safely stored and linked.

CONSISTATION OF DATABASE

The database consist of:
• 7 tables,
• 4 relationships,
• 3 views,
• 1 stored procedure,
• 1 trigger and assertion

CREATE TABLE Customer
(
customer_id INT NOT NULL,
customer_name VARCHAR(100) NOT NULL,
contact_number INT NOT NULL,
email VARCHAR(150) NOT NULL,
adress VARCHAR(150) NOT NULL,
PRIMARY KEY (customer_id)
);

CREATE TABLE Product
(
genre VARCHAR(50) NOT NULL,
price INT NOT NULL,
product_id INT NOT NULL,
title VARCHAR(150) NOT NULL,
PRIMARY KEY (product_id)
);

CREATE TABLE Staff
(
staff_id INT NOT NULL,
first_name VARCHAR(50) NOT NULL,
last_name VARCHAR(50) NOT NULL,
job_title VARCHAR(50) NOT NULL,
bank_name VARCHAR(50) NOT NULL,
acc_num INT NOT NULL,
PRIMARY KEY (staff_id)
);

CREATE TABLE Payment
(
pay_date DATE NOT NULL,
pay_amt INT NOT NULL,
payment_id INT NOT NULL,
PRIMARY KEY (payment_id)
);

CREATE TABLE Book
(
case_type VARCHAR(50) NOT NULL,
author VARCHAR(100) NOT NULL,
product_id INT NOT NULL,
PRIMARY KEY (product_id),
FOREIGN KEY (product_id) REFERENCES Product(product_id)
);

CREATE TABLE Movie
(
director VARCHAR(100) NOT NULL,
country VARCHAR(50) NOT NULL,
product_id INT NOT NULL,
PRIMARY KEY (product_id),
FOREIGN KEY (product_id) REFERENCES Product(product_id)
);

CREATE TABLE Music
(
album VARCHAR(100) NOT NULL,
artist VARCHAR(100) NOT NULL,
product_id INT NOT NULL,
PRIMARY KEY (product_id),
FOREIGN KEY (product_id) REFERENCES Product(product_id)
);

CREATE TABLE purchase
(
customer_id INT NOT NULL,
product_id INT NOT NULL,
PRIMARY KEY (customer_id, product_id),
FOREIGN KEY (customer_id) REFERENCES Customer(customer_id),
FOREIGN KEY (product_id) REFERENCES Product(product_id)
);

CREATE TABLE manages
(
staff_id INT NOT NULL,
payment_id INT NOT NULL,
PRIMARY KEY (staff_id, payment_id),
FOREIGN KEY (staff_id) REFERENCES Staff(staff_id),
FOREIGN KEY (payment_id) REFERENCES Payment(payment_id)
);

CREATE TABLE keep_records
(
staff_id INT NOT NULL,
product_id INT NOT NULL,
PRIMARY KEY (staff_id, product_id),
FOREIGN KEY (staff_id) REFERENCES Staff(staff_id),
FOREIGN KEY (product_id) REFERENCES Product(product_id)
);

IMPLEMENTATION

Project is implemented using C# language.
The application has:
• 3 insert statement
• 5 select statement
• 3 update statement
• 3 delete statement
