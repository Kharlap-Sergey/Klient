/* Options:
Date: 2020-03-13 09:29:42
Version: 5.80
Tip: To override a DTO option, remove "//" prefix before updating
BaseUrl: http://localhost:50357

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
using OrmLite.ServiceModel;
using OrmLite.ServiceInterface;


namespace OrmLite.ServiceInterface
{

    public partial class CravlByUri
        : IReturn<CravlByUriResponse>
    {
        public virtual int DeapValue { get; set; }
        public virtual string Uri { get; set; }
    }

    public partial class CravlByUriResponse
    {
        public virtual string Result { get; set; }
    }
}

namespace OrmLite.ServiceModel
{

    public partial class CreateDB
        : IReturn<CreateDBResponse>
    {
    }

    public partial class CreateDBResponse
    {
        public virtual string Result { get; set; }
    }

    public partial class CreateTable
        : IReturn<CreateTableResponse>
    {
        public virtual string Name { get; set; }
    }

    public partial class CreateTableResponse
    {
        public virtual string Result { get; set; }
    }

    public partial class DeleteAllTable
        : IReturn<Resp>
    {
    }

    public partial class ExtractEntities
        : IReturn<ExtractEntitiesResponse>
    {
    }

    public partial class ExtractEntitiesResponse
    {
        public virtual string Result { get; set; }
    }

    public partial class FindByEntity
        : IReturn<FindByEntityResponse>
    {
        public virtual string Entity { get; set; }
    }

    public partial class FindByEntityResponse
    {
        public FindByEntityResponse()
        {
            Result = new List<string>{};
        }

        public virtual List<string> Result { get; set; }
    }

    public partial class FindByWord
        : IReturn<FindByWordResponse>
    {
        public virtual string Word { get; set; }
    }

    public partial class FindByWordResponse
    {
        public FindByWordResponse()
        {
            Result = new List<string>{};
        }

        public virtual List<string> Result { get; set; }
    }

    public partial class GetArticls
        : IReturn<GetArticlsResponse>
    {
    }

    public partial class GetArticlsResponse
    {
        public GetArticlsResponse()
        {
            Result = new List<string>{};
        }

        public virtual List<string> Result { get; set; }
    }

    public partial class IsCrawlCompleted
        : IReturn<int>
    {
    }

    public partial class IsExtractEntitiesCompleted
        : IReturn<bool>
    {
    }

    public partial class Resp
    {
    }
}

