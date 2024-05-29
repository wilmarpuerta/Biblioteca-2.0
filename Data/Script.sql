-- Creación de las tablas

CREATE Table Books(
    Id INTEGER PRIMARY KEY AUTO_INCREMENT,
    title VARCHAR(225),
    Pages INTEGER(10),
    Language VARCHAR(125),
    PublicationDate DATE,
    Description TEXT
);

CREATE Table Authors(
    Id int PRIMARY KEY AUTO_INCREMENT,
    Name VARCHAR(125),
    LastName VARCHAR(45),
    Email VARCHAR(125),
    Nationality VARCHAR(125)
);

CREATE Table Editorials(
    Id INTEGER PRIMARY KEY AUTO_INCREMENT,
    Name VARCHAR(125),
    Address VARCHAR(125),
    Phone VARCHAR(35),
    Email VARCHAR(125)
);
