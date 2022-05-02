﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WCFSoapServiceLearn.Model;

namespace WCFSoapServiceLearn
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IEmployeeService" in both code and config file together.
    [ServiceContract]
    public interface IEmployeeService
    {
        [OperationContract]

        List<Employee> GetAllEmployees();

        [OperationContract]
        Employee Get(int id);

        [OperationContract]
        void Add(Employee e);

        [OperationContract]
        void Edit(Employee e);

        [OperationContract]
        void Remove(int id);

    }
}
