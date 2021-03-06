﻿using GDF_HRMS_v1.Data;
using GDF_HRMS_v1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GDF_HRMS_v1.Repository.IRepository
{
    public interface IEmployeePIRepository
    {
        ICollection<EmployeePI> GetEmployeePIs();
        ICollection<Region> GetAllRegions();

        ICollection<Religion> GetAllReligions();
        public ICollection<Country> GetAllCountries();
        public ICollection<Department> GetAllDepartments();

        ICollection<Nationality> GetAllNationalities();

        ICollection<Ethnicity> GetAllEthnicities();
        ICollection<Position> GetAllPositions();
        ICollection<MaritalStatus> GetAllMaritalStatus();
        EmployeePI GetEmployeePIById(int employeeId);
        Country GetCountryById(int countryId);
        Department GetDepartmentById(int departmentId);
        Ethnicity GetEthnicityById(int ethnicityId);
        MaritalStatus GetMaritalStatusById(int maritalStatusId);
        Nationality GetNationalityById(int nationalityId);
        Position GetPositionById(int positionId);
        Region GetRegionById(int regionId);
        Religion GetReligionById(int religionId);
        Address GetAddressById(int addressId);

        CareerHistory GetCareerHistoryById(int careerHistoryId);
        List<CareerHistory> GetEmployeeCHByEId(int employeeId);
        List<Address> GetAddressByEId(int employeeId);
        EmployeePI GetEmployeePIByRegNumber(int employeeRNumber);
       // ICollection<EmployeePI> GetEmployeePIByOtherCriteria(string employeeFname, string employeeLname, string employeePosition);
        EmployeePI GetEmployeePIByOtherCriteria(string employeeFname, string employeeLname, int employeePosition);
        bool EmployeePIExists(string name);
        bool ReligionExists(string name);
        bool ReligionExists(int id);
        bool CountryExists(string name);
        bool CountryExists(int id);
        bool NationalityExists(string name);
        bool NationalityExists(int id);
        bool DepartmentExists(string name);
        bool DepartmentExists(int id);
        bool EthnicityExists(string name);
        bool EthnicityExists(int id);
        bool MaritalStatusExists(string name);
        bool MaritalStatusExists(int id);
        bool PositionExists(string name);
        bool PositionExists(int id);
        bool RegionExists(string name);
        bool RegionExists(int id);
        bool EmployeePIExists(int id);
        bool EmployeeCHExists(int id);
        bool AddressExists(int id);
        bool CareerHistoryExists(int id);

        bool CreateEmployeeCH(CareerHistory careerHistory);
        bool CreateEmployeeAddress(Address address);

        bool CreateEmployeePI(CreateEmployeeDto employeePI);
        bool CreateReligion(Religion religion);

        bool CreateCountry(Country country);
        bool CreateNationality(Nationality nationality);
        bool CreateDepartment(Department department);
        bool CreateEthnicity(Ethnicity ethnicity);
        bool CreateMaritalStatus(MaritalStatus maritalStatus);
        bool CreatePosition(Position position);
        bool CreateRegion(Region region);
        bool UpdateEmployeePI(EmployeePI employeePI);
        bool DeleteEmployeePI(EmployeePI employeePI);
        bool DeleteCountry(Country country);
        bool DeleteDepartment(Department department);
        bool DeleteEthnicity(Ethnicity ethnicity);
        bool DeleteMaritalStatus(MaritalStatus maritalStatus);
        bool DeleteNationality(Nationality nationality);

        bool DeletePosition(Position position);
        bool DeleteRegion(Region region);
        bool DeleteAddress(Address address);

        bool DeleteCareerHistory(CareerHistory careerHistory);
        bool DeleteReligion(Religion religion);
        bool UpdateEmployeeCH(CareerHistory careerHistory);
        bool UpdateEmployeeAddress(Address address);
        bool Save();

      
    }
}