private enum SaveDataManager.STATE // TypeDefIndex: 9918
{
	// Fields
	public int value__; // 0x0
	public const SaveDataManager.STATE IDLE = 0;
	public const SaveDataManager.STATE INIT = 1;
	public const SaveDataManager.STATE SYSTEMDATA_LOAD = 2;
	public const SaveDataManager.STATE SYSTEMDATA_LOADWAIT = 3;
	public const SaveDataManager.STATE SYSTEMDATA_SAVE = 4;
	public const SaveDataManager.STATE SYSTEMDATA_SAVEWAIT = 5;
	public const SaveDataManager.STATE GAMEDATA_LOAD = 6;
	public const SaveDataManager.STATE GAMEDATA_LOADWAIT = 7;
	public const SaveDataManager.STATE GAMEDATA_SAVE = 8;
	public const SaveDataManager.STATE GAMEDATA_SAVEWAIT = 9;
	public const SaveDataManager.STATE GAMEDATA_SALVAGE = 10;
	public const SaveDataManager.STATE GAMEDATA_SALVAGEWAIT = 11;
	public const SaveDataManager.STATE GAMEDATA_DELETE = 12;
	public const SaveDataManager.STATE GAMEDATA_DELETEWAIT = 13;
}

