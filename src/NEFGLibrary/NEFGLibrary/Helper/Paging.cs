using System.Collections.Generic;

namespace NEFGLibrary.Helper
{
  /// <summary>
  ///   Filter Paging that use Generics, any list can be used to filter out only a specific page from the list.
  /// </summary>
  public static class Paging
  {
    /// <summary>
    ///   Updated Filter Paging to use Generics, any list can be used to filter out only a specific page from the list.
    /// </summary>
    /// <typeparam name="T">Type of list of objects.</typeparam>
    /// <param name="pageNumber">The page that needs to be returned.</param>
    /// <param name="rowsPerPage">How many rows per page is in the list.</param>
    /// <param name="result">Only the specific page is returned form the list with a maximum of rowsPerPage items.</param>
    /// <returns></returns>
    public static List<T> FilterPaging<T>(int? pageNumber, int? rowsPerPage, List<T> result)
    {
      if (pageNumber == 1)
      {
        if (rowsPerPage < result.Count) result = result.GetRange(0, rowsPerPage ?? 10);
      }
      else
      {
        var fromPage = (pageNumber ?? 1) * (rowsPerPage ?? 10) - (rowsPerPage ?? 10);
        var count = fromPage + (rowsPerPage ?? 10) > result.Count
          ? result.Count - fromPage
          : rowsPerPage ?? 10;
        result = result.GetRange(fromPage, count);
      }

      return result;
    }
  }
}