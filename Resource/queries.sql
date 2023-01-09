CREATE TABLE userBrojilo (
    id_brojila        INTEGER NOT NULL,
    user_name         VARCHAR2(32 CHAR) NOT NULL,
    user_street       VARCHAR2(32 CHAR) NOT NULL,
    user_street_num   INTEGER NOT NULL,
    user_city         VARCHAR2(32 CHAR) NOT NULL,
    user_postal_code  INTEGER  NOT NULL
);

ALTER TABLE brojilo ADD CONSTRAINT brojilo_pk PRIMARY KEY ( id_brojila );

CREATE TABLE usageBrojilo (
    id_brojila     INTEGER NOT NULL,
    usage          DECIMAL(10, 2) NOT NULL,
    month          VARCHAR(16) NOT NULL
);

ALTER TABLE potrosnja ADD CONSTRAINT potrosnja_pk PRIMARY KEY ( id_brojila );

SELECT * FROM brojilo;
SELECT * FROM potrosnja;