CREATE TABLE Person (
    Id INTEGER PRIMARY KEY AUTOINCREMENT,
    Name TEXT NOT NULL,
    Birthdate TEXT NOT NULL,
    Deathdate TEXT NULL,
    IsMarried INTEGER NOT NULL,
    IsMale INTEGER NOT NULL,
    Job TEXT,
    School TEXT,
    FatherId INTEGER NULL,
    MotherId INTEGER NULL,
    Image BLOB,
    FOREIGN KEY (FatherId) REFERENCES Person(Id),
    FOREIGN KEY (MotherId) REFERENCES Person(Id)
);

CREATE TABLE FamilyTree (
    Name TEXT NOT NULL
);
