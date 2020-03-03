/* Options:
Date: 2020-02-26 21:27:32
Version: 5.80
Tip: To override a DTO option, remove "//" prefix before updating
BaseUrl: http://localhost:54915

//GlobalNamespace: 
//MakePartial: True
//MakeVirtual: True
//MakeInternal: False
//MakeDataContractsExtensible: False
//AddReturnMarker: True
//AddDescriptionAsComments: True
//AddDataContractAttributes: False
//AddIndexesToDataMembers: False
//AddGeneratedCodeAttributes: False
//AddResponseStatus: False
//AddImplicitVersion: 
//InitializeCollections: True
//ExportValueTypes: False
//IncludeTypes: 
//ExcludeTypes: 
//AddNamespaces: 
//AddDefaultXmlNamespace: http://schemas.servicestack.net/types
*/

using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using ServiceStack;
using ServiceStack.DataAnnotations;
using WebApplication2.ServiceModel;


namespace WebApplication2.ServiceModel
{

    public partial class CravlByUri
        : IReturn<CravlByUriResponse>
    {
        public virtual string Uri { get; set; }
    }

    public partial class CravlByUriResponse
    {
        public virtual string Result { get; set; }
    }

    public partial class ExtractPagesByEntities
        : IReturn<ExtractPagesByEntitiesResponse>
    {
        public virtual string Entities { get; set; }
    }

    public partial class ExtractPagesByEntitiesResponse
    {
        public virtual string Result { get; set; }
    }

    public partial class FindPageByWords
        : IReturn<FindPageByWordsResponse>
    {
        public virtual string TextForFinding { get; set; }
    }

    public partial class FindPageByWordsResponse
    {
        public virtual string Result { get; set; }
    }

    public partial class GetAllDatabaseStoredInfomation
        : IReturn<GetAllDatabaseStoredInfomationResponse>
    {
    }

    public partial class GetAllDatabaseStoredInfomationResponse
    {
        public virtual string Result { get; set; }
    }

    [Route("/hello/{Name}")]
    public partial class Hello
        : IReturn<HelloResponse>
    {
        public virtual string Name { get; set; }
    }

    public partial class HelloResponse
    {
        public virtual string Result { get; set; }
    }
}

