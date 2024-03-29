﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using PTSLibrary;

/// <summary>
/// The web service to be used by the Customer browser website.
/// </summary>
/// <remarks>
/// Only functionality offered by this service is authentication and retrieval
/// of project details.
/// </remarks>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
// [System.Web.Script.Services.ScriptService]

public class PTSCustomerWebService : System.Web.Services.WebService
{
    private PTSCustomerFacade facade;
    public PTSCustomerWebService() {

        //Uncomment the following line if using designed components 
        //InitializeComponent(); 
        facade = new PTSCustomerFacade();
    }

    [WebMethod]
    public string HelloWorld() {
        return "Hello World";
    }
    /// <summary>
    /// Authenticates customer.
    /// </summary>
    /// <param name="username"></param>
    /// <param name="password"></param>
    /// <returns> Customer. </returns>
    [WebMethod]
    public int Authenticate(string username, string password)
    {
        return facade.Authenticate(username, password);
    }
    /// <summary>
    /// Gets list of projects by a particular customer.
    /// </summary>
    /// <param name="customerId"></param>
    /// <returns>List of projects by a particular customer. </returns>
    [WebMethod]
    public Project[] GetListOfProjects(int customerId)
    {
        return facade.GetListOfProjects(customerId);
    }
}