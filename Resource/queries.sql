CREATE TABLE userBrojilo (
    id_brojila        INTEGER NOT NULL,
    user_name         VARCHAR2(32 CHAR) NOT NULL,
    user_street       VARCHAR2(32 CHAR) NOT NULL,
    user_street_num   INTEGER NOT NULL,
    user_city         VARCHAR2(32 CHAR) NOT NULL,
    user_postal_code  INTEGER  NOT NULL,
    CONSTRAINT userBrojilo_PK PRIMARY KEY (Mbr)
);


CREATE TABLE usageBrojilo (
    id_brojila     INTEGER FOREIGN KEY,
    usage          DECIMAL(10, 2) NOT NULL,
    month          VARCHAR(16) NOT NULL,
    CONSTRAINT usageBrojilo_FK FOREIGN KEY (id_brojila) REFERENCES userBrojilo (id_brojila)
);

SELECT * FROM userBrojilo;
SELECT * FROM usageBrojilo;