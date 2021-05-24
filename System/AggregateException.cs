[DebuggerDisplayAttribute] // RVA: 0xAB5D0 Offset: 0xAB6D1 VA: 0xAB5D0
[Serializable]
public class AggregateException : Exception // TypeDefIndex: 138
{
	// Fields
	private ReadOnlyCollection<Exception> m_innerExceptions; // 0x88

	// Properties
	public ReadOnlyCollection<Exception> InnerExceptions { get; }

	// Methods

	// RVA: 0x190ACE0 Offset: 0x190ADE1 VA: 0x190ACE0
	public void .ctor() { }

	// RVA: 0x190ADC0 Offset: 0x190AEC1 VA: 0x190ADC0
	public void .ctor(IEnumerable<Exception> innerExceptions) { }

	// RVA: 0x190AEF0 Offset: 0x190AFF1 VA: 0x190AEF0
	public void .ctor(Exception[] innerExceptions) { }

	// RVA: 0x190AE30 Offset: 0x190AF31 VA: 0x190AE30
	public void .ctor(string message, IEnumerable<Exception> innerExceptions) { }

	// RVA: 0x190AF60 Offset: 0x190B061 VA: 0x190AF60
	public void .ctor(string message, Exception[] innerExceptions) { }

	// RVA: 0x190AF70 Offset: 0x190B071 VA: 0x190AF70
	private void .ctor(string message, IList<Exception> innerExceptions) { }

	// RVA: 0x190B340 Offset: 0x190B441 VA: 0x190B340
	internal void .ctor(IEnumerable<ExceptionDispatchInfo> innerExceptionInfos) { }

	// RVA: 0x190B3B0 Offset: 0x190B4B1 VA: 0x190B3B0
	internal void .ctor(string message, IEnumerable<ExceptionDispatchInfo> innerExceptionInfos) { }

	// RVA: 0x190B470 Offset: 0x190B571 VA: 0x190B470
	private void .ctor(string message, IList<ExceptionDispatchInfo> innerExceptionInfos) { }

	// RVA: 0x190B8B0 Offset: 0x190B9B1 VA: 0x190B8B0
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x190BA70 Offset: 0x190BB71 VA: 0x190BA70 Slot: 15
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x190BBD0 Offset: 0x190BCD1 VA: 0x190BBD0 Slot: 7
	public override Exception GetBaseException() { }

	// RVA: 0x190BC90 Offset: 0x190BD91 VA: 0x190BC90
	public ReadOnlyCollection<Exception> get_InnerExceptions() { }

	// RVA: 0x190BCA0 Offset: 0x190BDA1 VA: 0x190BCA0
	public AggregateException Flatten() { }

	// RVA: 0x190C060 Offset: 0x190C161 VA: 0x190C060 Slot: 3
	public override string ToString() { }
}

