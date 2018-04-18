﻿#region	License
//--------------------------------------------------
// <License>
//     <Copyright> 2018 © Top Nguyen </Copyright>
//     <Url> http://topnguyen.net/ </Url>
//     <Author> Top </Author>
//     <Project> Elect </Project>
//     <File>
//         <Name> ParameterInType.cs </Name>
//         <Created> 18/04/2018 10:58:11 AM </Created>
//         <Key> 89cce993-52cb-4926-b74a-90bf6c134ed8 </Key>
//     </File>
//     <Summary>
//         ParameterInType.cs is a part of Elect
//     </Summary>
// <License>
//--------------------------------------------------
#endregion License

using System.ComponentModel.DataAnnotations;

namespace Elect.Web.Swagger.Models
{
    public enum ParameterInType
    {
        [Display(Name = "header")]
        Header,

        [Display(Name = "path")]
        Route,

        [Display(Name = "query")]
        Query
    }
}