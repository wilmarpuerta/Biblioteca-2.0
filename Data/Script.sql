-- Creación de las tablas

CREATE Table books(
    Id INTEGER PRIMARY KEY,
    title VARCHAR(225),
    Pages INTEGER(10),
    Language VARCHAR(125),
    PublicationDate DATE,
    Description TEXT
);

CREATE Table authors(
    Id int PRIMARY KEY,
    Name VARCHAR(125),
    LastName VARCHAR(45),
    Email VARCHAR(125),
    Nationality VARCHAR(125)
);

CREATE Table editorials(
    Id INTEGER PRIMARY KEY,
    Name VARCHAR(125),
    Address VARCHAR(125),
    Phone VARCHAR(35),
    Email VARCHAR(125)
);
