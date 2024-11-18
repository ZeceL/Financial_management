CREATE TABLE Transaction_Types (
    transaction_type_id INT IDENTITY(1,1) PRIMARY KEY,
    transaction_type_name NVARCHAR(255) NOT NULL
);

CREATE TABLE Categories (
    category_id INT IDENTITY(1,1) PRIMARY KEY,
    name VARCHAR(255) NOT NULL
);

CREATE TABLE Transactions (
    transaction_id INT IDENTITY(1,1) PRIMARY KEY,
    amount DECIMAL(10, 2) NOT NULL,
    transaction_date DATE NOT NULL,
    transaction_type_id INT NOT NULL,
    category_id INT NOT NULL,
    FOREIGN KEY (transaction_type_id) REFERENCES Transaction_Types(transaction_type_id),
    FOREIGN KEY (category_id) REFERENCES Categories(category_id)
);

CREATE TABLE Budget (
    budget_id INT IDENTITY(1,1) PRIMARY KEY,
    amount DECIMAL(10, 2) NOT NULL,
    category_id INT NOT NULL,
    budget_start_date DATE NOT NULL,
    budget_end_date DATE NOT NULL,
    FOREIGN KEY (category_id) REFERENCES Categories(category_id)
);

CREATE TABLE Reminders (
    reminder_id INT IDENTITY(1,1) PRIMARY KEY,
    reminder_text TEXT NOT NULL,
    reminder_date DATE NOT NULL,
    completion_flag BIT NOT NULL
);
