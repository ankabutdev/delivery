CREATE TABLE "Companies"(
    "Id" UUID NOT NULL,
    "UserId" UUID NOT NULL,
    "mainId" UUID NULL,
    "Name" BIGINT NOT NULL,
    "Owner" VARCHAR(50) NULL,
    "CreatedAt" BIGINT NOT NULL,
    "CompanyType" BIGINT NOT NULL,
    "SiteUrl" VARCHAR(255) NOT NULL,
    "Region" VARCHAR(255) NOT NULL,
    "Employeesmin" BIGINT NOT NULL,
    "Employeesmax" BIGINT NOT NULL,
    "IncomeEnter" DECIMAL(8, 2) NOT NULL,
    "IncomeTo" DECIMAL(8, 2) NOT NULL,
    "Description" bigserial NOT NULL,
    "LatItude" VARCHAR(50) NOT NULL,
    "LongItude" VARCHAR(50) NOT NULL
);
CREATE TABLE "Product"(
    "id" BIGINT NOT NULL,
    "nameUzb" TEXT NOT NULL,
    "nameRus" TEXT NOT NULL,
    "nameEng" TEXT NOT NULL,
    "DescUzb" TEXT NOT NULL,
    "DescRus" TEXT NOT NULL,
    "DescEng" TEXT NOT NULL,
    "Price" DECIMAL(8, 2) NOT NULL,
    "priority" TEXT NOT NULL
);
CREATE TABLE "clients"(
    "Id" UUID NOT NULL,
    "UserId" UUID NOT NULL,
    "Fullname" BIGINT NOT NULL,
    "Status" VARCHAR(255) NOT NULL,
    "PhoneNumber" VARCHAR(255) NOT NULL
);
CREATE TABLE "Schedule"(
    "id" BIGINT NOT NULL,
    "Day" VARCHAR(255) NOT NULL,
    "StartDate" DATE NOT NULL,
    "EndDate" DATE NOT NULL,
    "companyId" BIGINT NOT NULL
);
CREATE TABLE "MenuProduct"(
    "id" BIGINT NOT NULL,
    "CategoryId" BIGINT NOT NULL
);
CREATE TABLE "Orders"(
    "Id" UUID NOT NULL,
    "ProductId" UUID NOT NULL,
    "column_3" BIGINT NOT NULL
);
CREATE TABLE "Category"(
    "id" BIGINT NOT NULL,
    "Name" TEXT NULL,
    "Desc" TEXT NOT NULL,
    "CompanyId" BIGINT NOT NULL
);
CREATE TABLE "Users"(
    "Id" UUID NOT NULL,
    "Fullname" VARCHAR(255) NOT NULL,
    "Password" VARCHAR(255) NOT NULL,
    "ImagePath" VARCHAR(255) NOT NULL,
    "UserRole" VARCHAR(255) NOT NULL
);