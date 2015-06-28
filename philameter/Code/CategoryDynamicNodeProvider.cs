using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MvcSiteMapProvider;
using philameter.DAL;

namespace philameter.Code
{
    public class CategoryDynamicNodeProvider : DynamicNodeProviderBase
    {
        public override IEnumerable<DynamicNode> GetDynamicNodeCollection(ISiteMapNode node)
        {
            using (var service = new PhilaModelService())
            {
                // Create a node for each album 
                foreach (var category in service.Categories.Get())
                {
                    DynamicNode dynamicNode = new DynamicNode();
                    dynamicNode.Title = category.Name;
                    dynamicNode.ParentKey = "_Home_Dashboard_GET_Home_";
                    //dynamicNode.ParentKey = "_Home_Dashboard_GET_Home__Home_Details_GET_Categories_";
                    //dynamicNode.ParentKey = "_Home_Dashboard_GET_Home__Home__GET_Categories_c27a4a94-80eb-45ba-9a61-774e80ba80de";
                    dynamicNode.Attributes["Icon"] = category.FontAwesomeIcon;
                    dynamicNode.RouteValues.Add("id", category.Id);

                    yield return dynamicNode;
                }
            }
        } 
    }
}