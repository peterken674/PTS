using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using PTSLibrary;

/// <summary>
/// The web service to be used by the Client browser website.
/// </summary>
/// <remarks>
/// Only functionality offered by this service is authentication and retrieval
/// of project details.
/// </remarks>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
// [System.Web.Script.Services.ScriptService]
public class PTSClientWebService : System.Web.Services.WebService
{
    public PTSClientFacade facade;

    public PTSClientWebService()
    {

        //Uncomment the following line if using designed components 
        //InitializeComponent(); 

        facade = new PTSClientFacade();
    }

    [WebMethod]
    public string HelloWorld()
    {
        return "Hello World";
    }

    /// <summary>
    /// Authenticates team leader.
    /// </summary>
    /// <param name="username"></param>
    /// <param name="password"></param>
    /// <returns> The team leader details. </returns>
    [WebMethod]
    public TeamLeader Authenticate(string username, string password)
    {
        return facade.Authenticate(username, password);
    }
    /// <summary>
    /// Gets list of projects associated to a particular team.
    /// </summary>
    /// <param name="teamId"></param>
    /// <returns> List of projects associated with a particular team. </returns>
    [WebMethod]
    public Project[] GetListOfProjects(int teamId)
    {
        return facade.GetListOfProjects(teamId);
    }

}
