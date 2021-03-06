// ------------------------------------------------------------------------
// ========================================================================
// THIS CODE AND INFORMATION ARE GENERATED BY AUTOMATIC CODE GENERATOR
// ========================================================================
// Template:   IDataSource.tt
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using WPAppStudio.Entities;
using WPAppStudio.Entities.Base;
using WPAppStudio.Shared;

namespace WPAppStudio.Repositories
{
    /// <summary>
    /// historyCollection interface.
    /// </summary>
    [System.Runtime.CompilerServices.CompilerGenerated]
    [System.CodeDom.Compiler.GeneratedCode("Radarc", "4.0")]
    public interface IhistoryCollection
    {
		ObservableCollection<historyCollectionSchema> GetData();
		ObservableCollection<historyCollectionSchema> Search(FilterSpecification filter);
    }
}
