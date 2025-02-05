
CREATE TABLE Banks (
    COMPE CHAR(3) NOT NULL PRIMARY KEY,
    ISPB CHAR(8) NOT NULL,
    Document CHAR(18) NOT NULL,
    LongName VARCHAR(255) NOT NULL,
    ShortName VARCHAR(255) NOT NULL,
    Network VARCHAR(10) NULL,
    Type VARCHAR(30) NULL,
    PixType VARCHAR(4) NULL,
    Url VARCHAR(255) NULL,
    DateOperationStarted CHAR(10) NULL,
    DatePixStarted CHAR(10) NULL,
    DateRegistered DATETIME NOT NULL,
    DateUpdated DATETIME NOT NULL);