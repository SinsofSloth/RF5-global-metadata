internal class FileSystemEnumerableIterator<TSource> : Iterator<TSource> // TypeDefIndex: 646
{
	// Fields
	private SearchResultHandler<TSource> _resultHandler; // 0x0
	private List<Directory.SearchData> searchStack; // 0x0
	private Directory.SearchData searchData; // 0x0
	private string searchCriteria; // 0x0
	private SafeFindHandle _hnd; // 0x0
	private bool needsParentPathDiscoveryDemand; // 0x0
	private bool empty; // 0x0
	private string userPath; // 0x0
	private SearchOption searchOption; // 0x0
	private string fullPath; // 0x0
	private string normalizedSearchPath; // 0x0
	private bool _checkHost; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(string path, string originalUserPath, string searchPattern, SearchOption searchOption, SearchResultHandler<TSource> resultHandler, bool checkHost) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B12C00 Offset: 0x2B12D01 VA: 0x2B12C00
	|-FileSystemEnumerableIterator<object>..ctor
	|-FileSystemEnumerableIterator<string>..ctor
	*/

	// RVA: -1 Offset: -1
	private void CommonInit() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B12F60 Offset: 0x2B13061 VA: 0x2B12F60
	|-FileSystemEnumerableIterator<object>.CommonInit
	*/

	// RVA: -1 Offset: -1
	private void .ctor(string fullPath, string normalizedSearchPath, string searchCriteria, string userPath, SearchOption searchOption, SearchResultHandler<TSource> resultHandler, bool checkHost) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B131D0 Offset: 0x2B132D1 VA: 0x2B131D0
	|-FileSystemEnumerableIterator<object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 11
	protected override Iterator<TSource> Clone() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B13440 Offset: 0x2B13541 VA: 0x2B13440
	|-FileSystemEnumerableIterator<object>.Clone
	*/

	// RVA: -1 Offset: -1 Slot: 12
	protected override void Dispose(bool disposing) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B13510 Offset: 0x2B13611 VA: 0x2B13510
	|-FileSystemEnumerableIterator<object>.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public override bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B135A0 Offset: 0x2B136A1 VA: 0x2B135A0
	|-FileSystemEnumerableIterator<object>.MoveNext
	*/

	// RVA: -1 Offset: -1
	private SearchResult CreateSearchResult(Directory.SearchData localSearchData, Win32Native.WIN32_FIND_DATA findData) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B13A70 Offset: 0x2B13B71 VA: 0x2B13A70
	|-FileSystemEnumerableIterator<object>.CreateSearchResult
	*/

	// RVA: -1 Offset: -1
	private void HandleError(int hr, string path) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B13B50 Offset: 0x2B13C51 VA: 0x2B13B50
	|-FileSystemEnumerableIterator<object>.HandleError
	*/

	// RVA: -1 Offset: -1
	private void AddSearchableDirsToStack(Directory.SearchData localSearchData) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B13BA0 Offset: 0x2B13CA1 VA: 0x2B13BA0
	|-FileSystemEnumerableIterator<object>.AddSearchableDirsToStack
	*/

	// RVA: -1 Offset: -1
	internal void DoDemand(string fullPathToDemand) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B13F60 Offset: 0x2B14061 VA: 0x2B13F60
	|-FileSystemEnumerableIterator<object>.DoDemand
	*/

	// RVA: -1 Offset: -1
	private static string NormalizeSearchPattern(string searchPattern) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B13F70 Offset: 0x2B14071 VA: 0x2B13F70
	|-FileSystemEnumerableIterator<object>.NormalizeSearchPattern
	*/

	// RVA: -1 Offset: -1
	private static string GetNormalizedSearchCriteria(string fullSearchString, string fullPathMod) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B14050 Offset: 0x2B14151 VA: 0x2B14050
	|-FileSystemEnumerableIterator<object>.GetNormalizedSearchCriteria
	*/

	// RVA: -1 Offset: -1
	private static string GetFullSearchString(string fullPath, string searchPattern) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B14110 Offset: 0x2B14211 VA: 0x2B14110
	|-FileSystemEnumerableIterator<object>.GetFullSearchString
	*/
}

