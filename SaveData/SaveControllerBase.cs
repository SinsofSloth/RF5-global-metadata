public abstract class SaveControllerBase // TypeDefIndex: 9908
{
	// Fields
	protected SaveControllerBase.STATE State; // 0x10
	protected SaveDataBase TargetData; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x17F9E0 Offset: 0x17FAE1 VA: 0x17F9E0
	private string <FilePath>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x17F9F0 Offset: 0x17FAF1 VA: 0x17F9F0
	private ErrorCode <ErrorCode>k__BackingField; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x17FA00 Offset: 0x17FB01 VA: 0x17FA00
	private string <ErrorResult>k__BackingField; // 0x30

	// Properties
	public virtual bool IsBusy { get; }
	public string FilePath { get; set; }
	public ErrorCode ErrorCode { get; set; }
	public string ErrorResult { get; set; }

	// Methods

	// RVA: 0x20F6280 Offset: 0x20F6381 VA: 0x20F6280 Slot: 4
	public virtual bool get_IsBusy() { }

	// RVA: -1 Offset: -1 Slot: 5
	public abstract string GetFilePath(string filename) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AD340 Offset: 0x1AD441 VA: 0x1AD340
	// RVA: 0x20F6290 Offset: 0x20F6391 VA: 0x20F6290
	public string get_FilePath() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AD350 Offset: 0x1AD451 VA: 0x1AD350
	// RVA: 0x20F62A0 Offset: 0x20F63A1 VA: 0x20F62A0
	protected void set_FilePath(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AD360 Offset: 0x1AD461 VA: 0x1AD360
	// RVA: 0x20F62B0 Offset: 0x20F63B1 VA: 0x20F62B0
	public ErrorCode get_ErrorCode() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AD370 Offset: 0x1AD471 VA: 0x1AD370
	// RVA: 0x20F62C0 Offset: 0x20F63C1 VA: 0x20F62C0
	protected void set_ErrorCode(ErrorCode value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AD380 Offset: 0x1AD481 VA: 0x1AD380
	// RVA: 0x20F62D0 Offset: 0x20F63D1 VA: 0x20F62D0
	public string get_ErrorResult() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AD390 Offset: 0x1AD491 VA: 0x1AD390
	// RVA: 0x20F62E0 Offset: 0x20F63E1 VA: 0x20F62E0
	protected void set_ErrorResult(string value) { }

	// RVA: 0x20F62F0 Offset: 0x20F63F1 VA: 0x20F62F0
	public void ErrorSet(ErrorCode errorCode, string errorResult) { }

	// RVA: 0x20F6300 Offset: 0x20F6401 VA: 0x20F6300
	public void Save(SaveDataBase savedata) { }

	// RVA: 0x20F6380 Offset: 0x20F6481 VA: 0x20F6380
	public void Load(SaveDataBase savedata) { }

	// RVA: 0x20F6400 Offset: 0x20F6501 VA: 0x20F6400
	public void Delete(SaveDataBase savedata) { }

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void Create() { }

	// RVA: -1 Offset: -1 Slot: 7
	public abstract void Destroy() { }

	// RVA: 0x20F6430 Offset: 0x20F6531 VA: 0x20F6430 Slot: 8
	public virtual void Update() { }

	// RVA: -1 Offset: -1 Slot: 9
	public abstract void SaveData(string filename, byte[] savedata) { }

	// RVA: -1 Offset: -1 Slot: 10
	public abstract void LoadData(string filename, out byte[] savedata) { }

	// RVA: -1 Offset: -1 Slot: 11
	public abstract void DeleteData(string filename) { }

	// RVA: -1 Offset: -1 Slot: 12
	public abstract bool IsExisting(ulong applicationId) { }

	// RVA: 0x20F6530 Offset: 0x20F6631 VA: 0x20F6530
	protected void .ctor() { }
}

public abstract class SaveControllerBase // TypeDefIndex: 9908
{
	// Fields
	protected SaveControllerBase.STATE State; // 0x10
	protected SaveDataBase TargetData; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x17F9E0 Offset: 0x17FAE1 VA: 0x17F9E0
	private string <FilePath>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x17F9F0 Offset: 0x17FAF1 VA: 0x17F9F0
	private ErrorCode <ErrorCode>k__BackingField; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x17FA00 Offset: 0x17FB01 VA: 0x17FA00
	private string <ErrorResult>k__BackingField; // 0x30

	// Properties
	public virtual bool IsBusy { get; }
	public string FilePath { get; set; }
	public ErrorCode ErrorCode { get; set; }
	public string ErrorResult { get; set; }

	// Methods

	// RVA: 0x20F6280 Offset: 0x20F6381 VA: 0x20F6280 Slot: 4
	public virtual bool get_IsBusy() { }

	// RVA: -1 Offset: -1 Slot: 5
	public abstract string GetFilePath(string filename) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AD340 Offset: 0x1AD441 VA: 0x1AD340
	// RVA: 0x20F6290 Offset: 0x20F6391 VA: 0x20F6290
	public string get_FilePath() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AD350 Offset: 0x1AD451 VA: 0x1AD350
	// RVA: 0x20F62A0 Offset: 0x20F63A1 VA: 0x20F62A0
	protected void set_FilePath(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AD360 Offset: 0x1AD461 VA: 0x1AD360
	// RVA: 0x20F62B0 Offset: 0x20F63B1 VA: 0x20F62B0
	public ErrorCode get_ErrorCode() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AD370 Offset: 0x1AD471 VA: 0x1AD370
	// RVA: 0x20F62C0 Offset: 0x20F63C1 VA: 0x20F62C0
	protected void set_ErrorCode(ErrorCode value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AD380 Offset: 0x1AD481 VA: 0x1AD380
	// RVA: 0x20F62D0 Offset: 0x20F63D1 VA: 0x20F62D0
	public string get_ErrorResult() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AD390 Offset: 0x1AD491 VA: 0x1AD390
	// RVA: 0x20F62E0 Offset: 0x20F63E1 VA: 0x20F62E0
	protected void set_ErrorResult(string value) { }

	// RVA: 0x20F62F0 Offset: 0x20F63F1 VA: 0x20F62F0
	public void ErrorSet(ErrorCode errorCode, string errorResult) { }

	// RVA: 0x20F6300 Offset: 0x20F6401 VA: 0x20F6300
	public void Save(SaveDataBase savedata) { }

	// RVA: 0x20F6380 Offset: 0x20F6481 VA: 0x20F6380
	public void Load(SaveDataBase savedata) { }

	// RVA: 0x20F6400 Offset: 0x20F6501 VA: 0x20F6400
	public void Delete(SaveDataBase savedata) { }

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void Create() { }

	// RVA: -1 Offset: -1 Slot: 7
	public abstract void Destroy() { }

	// RVA: 0x20F6430 Offset: 0x20F6531 VA: 0x20F6430 Slot: 8
	public virtual void Update() { }

	// RVA: -1 Offset: -1 Slot: 9
	public abstract void SaveData(string filename, byte[] savedata) { }

	// RVA: -1 Offset: -1 Slot: 10
	public abstract void LoadData(string filename, out byte[] savedata) { }

	// RVA: -1 Offset: -1 Slot: 11
	public abstract void DeleteData(string filename) { }

	// RVA: -1 Offset: -1 Slot: 12
	public abstract bool IsExisting(ulong applicationId) { }

	// RVA: 0x20F6530 Offset: 0x20F6631 VA: 0x20F6530
	protected void .ctor() { }
}

public abstract class SaveControllerBase // TypeDefIndex: 9908
{
	// Fields
	protected SaveControllerBase.STATE State; // 0x10
	protected SaveDataBase TargetData; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x17F9E0 Offset: 0x17FAE1 VA: 0x17F9E0
	private string <FilePath>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x17F9F0 Offset: 0x17FAF1 VA: 0x17F9F0
	private ErrorCode <ErrorCode>k__BackingField; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x17FA00 Offset: 0x17FB01 VA: 0x17FA00
	private string <ErrorResult>k__BackingField; // 0x30

	// Properties
	public virtual bool IsBusy { get; }
	public string FilePath { get; set; }
	public ErrorCode ErrorCode { get; set; }
	public string ErrorResult { get; set; }

	// Methods

	// RVA: 0x20F6280 Offset: 0x20F6381 VA: 0x20F6280 Slot: 4
	public virtual bool get_IsBusy() { }

	// RVA: -1 Offset: -1 Slot: 5
	public abstract string GetFilePath(string filename) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AD340 Offset: 0x1AD441 VA: 0x1AD340
	// RVA: 0x20F6290 Offset: 0x20F6391 VA: 0x20F6290
	public string get_FilePath() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AD350 Offset: 0x1AD451 VA: 0x1AD350
	// RVA: 0x20F62A0 Offset: 0x20F63A1 VA: 0x20F62A0
	protected void set_FilePath(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AD360 Offset: 0x1AD461 VA: 0x1AD360
	// RVA: 0x20F62B0 Offset: 0x20F63B1 VA: 0x20F62B0
	public ErrorCode get_ErrorCode() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AD370 Offset: 0x1AD471 VA: 0x1AD370
	// RVA: 0x20F62C0 Offset: 0x20F63C1 VA: 0x20F62C0
	protected void set_ErrorCode(ErrorCode value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AD380 Offset: 0x1AD481 VA: 0x1AD380
	// RVA: 0x20F62D0 Offset: 0x20F63D1 VA: 0x20F62D0
	public string get_ErrorResult() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AD390 Offset: 0x1AD491 VA: 0x1AD390
	// RVA: 0x20F62E0 Offset: 0x20F63E1 VA: 0x20F62E0
	protected void set_ErrorResult(string value) { }

	// RVA: 0x20F62F0 Offset: 0x20F63F1 VA: 0x20F62F0
	public void ErrorSet(ErrorCode errorCode, string errorResult) { }

	// RVA: 0x20F6300 Offset: 0x20F6401 VA: 0x20F6300
	public void Save(SaveDataBase savedata) { }

	// RVA: 0x20F6380 Offset: 0x20F6481 VA: 0x20F6380
	public void Load(SaveDataBase savedata) { }

	// RVA: 0x20F6400 Offset: 0x20F6501 VA: 0x20F6400
	public void Delete(SaveDataBase savedata) { }

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void Create() { }

	// RVA: -1 Offset: -1 Slot: 7
	public abstract void Destroy() { }

	// RVA: 0x20F6430 Offset: 0x20F6531 VA: 0x20F6430 Slot: 8
	public virtual void Update() { }

	// RVA: -1 Offset: -1 Slot: 9
	public abstract void SaveData(string filename, byte[] savedata) { }

	// RVA: -1 Offset: -1 Slot: 10
	public abstract void LoadData(string filename, out byte[] savedata) { }

	// RVA: -1 Offset: -1 Slot: 11
	public abstract void DeleteData(string filename) { }

	// RVA: -1 Offset: -1 Slot: 12
	public abstract bool IsExisting(ulong applicationId) { }

	// RVA: 0x20F6530 Offset: 0x20F6631 VA: 0x20F6530
	protected void .ctor() { }
}

public abstract class SaveControllerBase // TypeDefIndex: 9908
{
	// Fields
	protected SaveControllerBase.STATE State; // 0x10
	protected SaveDataBase TargetData; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x17F9E0 Offset: 0x17FAE1 VA: 0x17F9E0
	private string <FilePath>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x17F9F0 Offset: 0x17FAF1 VA: 0x17F9F0
	private ErrorCode <ErrorCode>k__BackingField; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x17FA00 Offset: 0x17FB01 VA: 0x17FA00
	private string <ErrorResult>k__BackingField; // 0x30

	// Properties
	public virtual bool IsBusy { get; }
	public string FilePath { get; set; }
	public ErrorCode ErrorCode { get; set; }
	public string ErrorResult { get; set; }

	// Methods

	// RVA: 0x20F6280 Offset: 0x20F6381 VA: 0x20F6280 Slot: 4
	public virtual bool get_IsBusy() { }

	// RVA: -1 Offset: -1 Slot: 5
	public abstract string GetFilePath(string filename) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AD340 Offset: 0x1AD441 VA: 0x1AD340
	// RVA: 0x20F6290 Offset: 0x20F6391 VA: 0x20F6290
	public string get_FilePath() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AD350 Offset: 0x1AD451 VA: 0x1AD350
	// RVA: 0x20F62A0 Offset: 0x20F63A1 VA: 0x20F62A0
	protected void set_FilePath(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AD360 Offset: 0x1AD461 VA: 0x1AD360
	// RVA: 0x20F62B0 Offset: 0x20F63B1 VA: 0x20F62B0
	public ErrorCode get_ErrorCode() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AD370 Offset: 0x1AD471 VA: 0x1AD370
	// RVA: 0x20F62C0 Offset: 0x20F63C1 VA: 0x20F62C0
	protected void set_ErrorCode(ErrorCode value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AD380 Offset: 0x1AD481 VA: 0x1AD380
	// RVA: 0x20F62D0 Offset: 0x20F63D1 VA: 0x20F62D0
	public string get_ErrorResult() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AD390 Offset: 0x1AD491 VA: 0x1AD390
	// RVA: 0x20F62E0 Offset: 0x20F63E1 VA: 0x20F62E0
	protected void set_ErrorResult(string value) { }

	// RVA: 0x20F62F0 Offset: 0x20F63F1 VA: 0x20F62F0
	public void ErrorSet(ErrorCode errorCode, string errorResult) { }

	// RVA: 0x20F6300 Offset: 0x20F6401 VA: 0x20F6300
	public void Save(SaveDataBase savedata) { }

	// RVA: 0x20F6380 Offset: 0x20F6481 VA: 0x20F6380
	public void Load(SaveDataBase savedata) { }

	// RVA: 0x20F6400 Offset: 0x20F6501 VA: 0x20F6400
	public void Delete(SaveDataBase savedata) { }

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void Create() { }

	// RVA: -1 Offset: -1 Slot: 7
	public abstract void Destroy() { }

	// RVA: 0x20F6430 Offset: 0x20F6531 VA: 0x20F6430 Slot: 8
	public virtual void Update() { }

	// RVA: -1 Offset: -1 Slot: 9
	public abstract void SaveData(string filename, byte[] savedata) { }

	// RVA: -1 Offset: -1 Slot: 10
	public abstract void LoadData(string filename, out byte[] savedata) { }

	// RVA: -1 Offset: -1 Slot: 11
	public abstract void DeleteData(string filename) { }

	// RVA: -1 Offset: -1 Slot: 12
	public abstract bool IsExisting(ulong applicationId) { }

	// RVA: 0x20F6530 Offset: 0x20F6631 VA: 0x20F6530
	protected void .ctor() { }
}

public abstract class SaveControllerBase // TypeDefIndex: 9908
{
	// Fields
	protected SaveControllerBase.STATE State; // 0x10
	protected SaveDataBase TargetData; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x17F9E0 Offset: 0x17FAE1 VA: 0x17F9E0
	private string <FilePath>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x17F9F0 Offset: 0x17FAF1 VA: 0x17F9F0
	private ErrorCode <ErrorCode>k__BackingField; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x17FA00 Offset: 0x17FB01 VA: 0x17FA00
	private string <ErrorResult>k__BackingField; // 0x30

	// Properties
	public virtual bool IsBusy { get; }
	public string FilePath { get; set; }
	public ErrorCode ErrorCode { get; set; }
	public string ErrorResult { get; set; }

	// Methods

	// RVA: 0x20F6280 Offset: 0x20F6381 VA: 0x20F6280 Slot: 4
	public virtual bool get_IsBusy() { }

	// RVA: -1 Offset: -1 Slot: 5
	public abstract string GetFilePath(string filename) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AD340 Offset: 0x1AD441 VA: 0x1AD340
	// RVA: 0x20F6290 Offset: 0x20F6391 VA: 0x20F6290
	public string get_FilePath() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AD350 Offset: 0x1AD451 VA: 0x1AD350
	// RVA: 0x20F62A0 Offset: 0x20F63A1 VA: 0x20F62A0
	protected void set_FilePath(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AD360 Offset: 0x1AD461 VA: 0x1AD360
	// RVA: 0x20F62B0 Offset: 0x20F63B1 VA: 0x20F62B0
	public ErrorCode get_ErrorCode() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AD370 Offset: 0x1AD471 VA: 0x1AD370
	// RVA: 0x20F62C0 Offset: 0x20F63C1 VA: 0x20F62C0
	protected void set_ErrorCode(ErrorCode value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AD380 Offset: 0x1AD481 VA: 0x1AD380
	// RVA: 0x20F62D0 Offset: 0x20F63D1 VA: 0x20F62D0
	public string get_ErrorResult() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AD390 Offset: 0x1AD491 VA: 0x1AD390
	// RVA: 0x20F62E0 Offset: 0x20F63E1 VA: 0x20F62E0
	protected void set_ErrorResult(string value) { }

	// RVA: 0x20F62F0 Offset: 0x20F63F1 VA: 0x20F62F0
	public void ErrorSet(ErrorCode errorCode, string errorResult) { }

	// RVA: 0x20F6300 Offset: 0x20F6401 VA: 0x20F6300
	public void Save(SaveDataBase savedata) { }

	// RVA: 0x20F6380 Offset: 0x20F6481 VA: 0x20F6380
	public void Load(SaveDataBase savedata) { }

	// RVA: 0x20F6400 Offset: 0x20F6501 VA: 0x20F6400
	public void Delete(SaveDataBase savedata) { }

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void Create() { }

	// RVA: -1 Offset: -1 Slot: 7
	public abstract void Destroy() { }

	// RVA: 0x20F6430 Offset: 0x20F6531 VA: 0x20F6430 Slot: 8
	public virtual void Update() { }

	// RVA: -1 Offset: -1 Slot: 9
	public abstract void SaveData(string filename, byte[] savedata) { }

	// RVA: -1 Offset: -1 Slot: 10
	public abstract void LoadData(string filename, out byte[] savedata) { }

	// RVA: -1 Offset: -1 Slot: 11
	public abstract void DeleteData(string filename) { }

	// RVA: -1 Offset: -1 Slot: 12
	public abstract bool IsExisting(ulong applicationId) { }

	// RVA: 0x20F6530 Offset: 0x20F6631 VA: 0x20F6530
	protected void .ctor() { }
}

