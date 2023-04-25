CREATE TABLE
    IF NOT EXISTS accounts(
        id VARCHAR(255) NOT NULL primary key COMMENT 'primary key',
        createdAt DATETIME DEFAULT CURRENT_TIMESTAMP COMMENT 'Time Created',
        updatedAt DATETIME DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP COMMENT 'Last Update',
        name varchar(255) COMMENT 'User Name',
        email varchar(255) COMMENT 'User Email',
        picture varchar(255) COMMENT 'User Picture'
    ) default charset utf8mb4 COMMENT '';

CREATE TABLE
    IF NOT EXISTS cars(
        id INT NOT NULL PRIMARY KEY AUTO_INCREMENT COMMENT 'primary key',
        make VARCHAR(255) NOT NULL,
        model VARCHAR(255) NOT NULL,
        price MEDIUMINT NOT NULL,
        year SMALLINT NOT NULL DEFAULT 1990,
        hasTires BOOLEAN NOT NULL DEFAULT true,
        createdAt DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
        updatedAt DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
        color VARCHAR(8) DEFAULT '#FFFFFF'
    ) default charset utf8mb4 COMMENT 'emojis enabled 🦞';

INSERT INTO
    cars(
        make,
        model,
        price,
        year,
        hasTires,
        color
    )
values (
        'Chevrolet',
        'Corvette',
        5000,
        2015,
        true,
        "#FFFF00"
    );

INSERT INTO
    cars(
        make,
        model,
        price,
        year,
        hasTires
    )
values (
        'mazda',
        'miata',
        5000,
        2005,
        true
    ), (
        'subaru',
        'impreza',
        13000,
        2013,
        true
    );

SELECT * FROM cars ORDER BY price DESC LIMIT 1;

SELECT * FROM cars WHERE make = 'mazda' AND model = 'miata';

SELECT * FROM cars WHERE id = 1;

UPDATE cars SET model = 'rx-7', color = '#000000' WHERE id = 4;

DELETE FROM cars WHERE id = 5 ;

-- DROP TABLE cars;

-- --------------------------

-- Setup for Houses

CREATE TABLE
    IF NOT EXISTS houses(
        id INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
        bedRooms SMALLINT NOT NULL,
        bathRooms SMALLINT NOT NULL,
        price MEDIUMINT NOT NULL,
        yearBuilt SMALLINT NOT NULL DEFAULT 1700,
        copyText VARCHAR(255) NOT NULL,
        createdAt DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
        updatedAt DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
        color VARCHAR(8) DEFAULT '#FFFFFF'
    ) default charset utf8mb4 COMMENT 'emojis enabled 🦞';

INSERT INTO
    houses(
        bedRooms,
        bathRooms,
        price,
        yearBuilt,
        copyText,
        color
    )
VALUES (
        2,
        3,
        46000,
        1997,
        "This place is so small the beds are in the baths.",
        '#c5c799'
    ), (
        6,
        6,
        550000,
        2015,
        "Bigger house for sale. Yo.",
        "#886644"
    );

SELECT * FROM houses ORDER BY price DESC LIMIT 1;

SELECT * FROM houses WHERE `yearBuilt` > 1996;

SELECT * FROM houses WHERE id = 1;

UPDATE houses
SET
    `copyText` = "The new and updated description, which we're calling copyText",
    color = '#887766'
WHERE id = 3;

DELETE FROM houses WHERE id = 5;

-- DROP TABLE houses;