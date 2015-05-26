using System.Collections.Generic;

namespace OxxCommerceStarterKit.Web.Business.FacetRegistry
{
    public class FacetRegistry : IFacetRegistry
    {
        static List<FacetDefinition>_facetRegistry = new List<FacetDefinition>();

        public FacetRegistry()
        {
            
        }

        public List<FacetDefinition> FacetDefinitions {
            get
            {
                return _facetRegistry;
            }
            set
            {
                _facetRegistry = value;
            }
        }
        
    }
}