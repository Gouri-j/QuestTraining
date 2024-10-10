CREATE TABLE accounts (
    id INT PRIMARY KEY IDENTITY(100,1),
    account_number BIGINT UNIQUE,
    name VARCHAR(50) NOT NULL,
    date_of_birth DATE,
    address VARCHAR(100) NOT NULL,
    phone_number VARCHAR(20),
    email VARCHAR(50) NOT NULL UNIQUE,
    account_type VARCHAR(50) NOT NULL, 
    balance DECIMAL(18,2) DEFAULT 0
);


insert into accounts(account_number,name,date_of_birth,address,phone_number,email,account_type,balance) values
(1001,'John Doe','1985-05-15','Elm Street, Springfield IL',1238886545,'johndoe@example.com','Checking', 1500.75),
(1002, 'Jane Smith', '1990-08-20','Oak Avenue Lincoln', 7633509864, 'janesmith@example.com', 'Savings', 2300.40),
(1003, 'Michael Johnson', '1978-11-30', 'Pine Road, Madison', 0974321568, 'michaelj@example.com', 'Business', 10500.00),
(1004, 'Emily Davis', '1995-02-14','Maple Lane', 7394560732, 'emilyd@example.com', 'Checking', 750.25),
(1005, 'Robert Wilson','1982-09-01','Cedar Blvd Portland', 7644797890, 'robertw@example.com', 'Savings', 4800.60);






CREATE TABLE Transactions (
    id INT PRIMARY KEY IDENTITY(200,1),
    from_account_id INT,
    to_account_id INT, 
    amount DECIMAL(18,2),
    transaction_date DATETIME DEFAULT GETDATE(),
    transaction_type VARCHAR(50),
    CONSTRAINT fk_to_account_id FOREIGN KEY (to_account_id) REFERENCES accounts(id),
    CONSTRAINT fk_from_account_id FOREIGN KEY (from_account_id) REFERENCES accounts(id)
);


insert into Transactions(from_account_id, to_account_id, amount, transaction_date,transaction_type) values
(101, 104, 5000, '2023-08-18', 'Payment'),
(102, 101, 700, '2023-12-3', 'Purchase'),
(102, 103, 300, '2020-3-20', 'fees'),
(103, 101, 1000, '2021-7-1', 'Refund');






--Create account
insert into accounts(account_number, name, date_of_birth, address, phone_number, email, account_type, balance)
values(9999,'Alex','2002-1-13','beiyn street','6554788334','alex@gmail.com','checking',80000.00);

--delete
delete from accounts where account_number = 1004;

--update
update accounts set account_type ='Business' where account_number = 1001;

--deposit
update accounts set balance = balance + 100 where id = 103;
insert into transactions(from_account_id, to_account_id, amount, transaction_type)
values(102,103,100,'deposit');
select id, account_number, name,balance from accounts where id = 103;


--withdraw
update accounts set balance = balance - 500 where id =100;
insert into transactions(from_account_id, to_account_id, amount, transaction_type)
values(null,100,1000,'withdraw');
select account_number, name,balance from accounts where id = 100;


--History.
select Transactions.id as transaction_id,
       Transactions.from_account_id ,
	   Transactions.to_account_id,
	   Transactions.amount,
	   Transactions.transaction_type,
	   Transactions.transaction_date,
	   accounts.name as customer_name,
	   accounts.balance
	   from Transactions left join accounts on accounts.id = Transactions.to_account_id order by Transactions.transaction_date desc;


