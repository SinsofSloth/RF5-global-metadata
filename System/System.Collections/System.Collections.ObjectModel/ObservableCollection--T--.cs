[Serializable]
public class ObservableCollection<T> : Collection<T>, INotifyCollectionChanged, INotifyPropertyChanged // TypeDefIndex: 2067
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0xBCFE0 Offset: 0xBD0E1 VA: 0xBCFE0
	private NotifyCollectionChangedEventHandler CollectionChanged; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0xBCFF0 Offset: 0xBD0F1 VA: 0xBCFF0
	private PropertyChangedEventHandler PropertyChanged; // 0x0
	private ObservableCollection.SimpleMonitor<T> _monitor; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2EE7DE0 Offset: 0x2EE7EE1 VA: 0x2EE7DE0
	|-ObservableCollection<object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 38
	private void System.ComponentModel.INotifyPropertyChanged.add_PropertyChanged(PropertyChangedEventHandler value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2EE7E70 Offset: 0x2EE7F71 VA: 0x2EE7E70
	|-ObservableCollection<object>.System.ComponentModel.INotifyPropertyChanged.add_PropertyChanged
	*/

	// RVA: -1 Offset: -1 Slot: 39
	private void System.ComponentModel.INotifyPropertyChanged.remove_PropertyChanged(PropertyChangedEventHandler value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2EE7E90 Offset: 0x2EE7F91 VA: 0x2EE7E90
	|-ObservableCollection<object>.System.ComponentModel.INotifyPropertyChanged.remove_PropertyChanged
	*/

	[CompilerGeneratedAttribute] // RVA: 0xBDBD0 Offset: 0xBDCD1 VA: 0xBDBD0
	// RVA: -1 Offset: -1 Slot: 40
	public virtual void add_CollectionChanged(NotifyCollectionChangedEventHandler value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2EE7EB0 Offset: 0x2EE7FB1 VA: 0x2EE7EB0
	|-ObservableCollection<object>.add_CollectionChanged
	*/

	[CompilerGeneratedAttribute] // RVA: 0xBDBE0 Offset: 0xBDCE1 VA: 0xBDBE0
	// RVA: -1 Offset: -1 Slot: 41
	public virtual void remove_CollectionChanged(NotifyCollectionChangedEventHandler value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2EE7F70 Offset: 0x2EE8071 VA: 0x2EE7F70
	|-ObservableCollection<object>.remove_CollectionChanged
	*/

	// RVA: -1 Offset: -1 Slot: 32
	protected override void ClearItems() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2EE8030 Offset: 0x2EE8131 VA: 0x2EE8030
	|-ObservableCollection<object>.ClearItems
	*/

	// RVA: -1 Offset: -1 Slot: 34
	protected override void RemoveItem(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2EE8110 Offset: 0x2EE8211 VA: 0x2EE8110
	|-ObservableCollection<object>.RemoveItem
	*/

	// RVA: -1 Offset: -1 Slot: 33
	protected override void InsertItem(int index, T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2EE8230 Offset: 0x2EE8331 VA: 0x2EE8230
	|-ObservableCollection<object>.InsertItem
	*/

	// RVA: -1 Offset: -1 Slot: 35
	protected override void SetItem(int index, T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2EE8340 Offset: 0x2EE8441 VA: 0x2EE8340
	|-ObservableCollection<object>.SetItem
	*/

	// RVA: -1 Offset: -1 Slot: 42
	protected virtual void OnPropertyChanged(PropertyChangedEventArgs e) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2EE8450 Offset: 0x2EE8551 VA: 0x2EE8450
	|-ObservableCollection<object>.OnPropertyChanged
	*/

	[CompilerGeneratedAttribute] // RVA: 0xBDBF0 Offset: 0xBDCF1 VA: 0xBDBF0
	// RVA: -1 Offset: -1 Slot: 43
	protected virtual void add_PropertyChanged(PropertyChangedEventHandler value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2EE8470 Offset: 0x2EE8571 VA: 0x2EE8470
	|-ObservableCollection<object>.add_PropertyChanged
	*/

	[CompilerGeneratedAttribute] // RVA: 0xBDC00 Offset: 0xBDD01 VA: 0xBDC00
	// RVA: -1 Offset: -1 Slot: 44
	protected virtual void remove_PropertyChanged(PropertyChangedEventHandler value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2EE8530 Offset: 0x2EE8631 VA: 0x2EE8530
	|-ObservableCollection<object>.remove_PropertyChanged
	*/

	// RVA: -1 Offset: -1 Slot: 45
	protected virtual void OnCollectionChanged(NotifyCollectionChangedEventArgs e) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2EE85F0 Offset: 0x2EE86F1 VA: 0x2EE85F0
	|-ObservableCollection<object>.OnCollectionChanged
	*/

	// RVA: -1 Offset: -1
	protected IDisposable BlockReentrancy() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2EE8720 Offset: 0x2EE8821 VA: 0x2EE8720
	|-ObservableCollection<object>.BlockReentrancy
	*/

	// RVA: -1 Offset: -1
	protected void CheckReentrancy() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2EE8760 Offset: 0x2EE8861 VA: 0x2EE8760
	|-ObservableCollection<object>.CheckReentrancy
	*/

	// RVA: -1 Offset: -1
	private void OnPropertyChanged(string propertyName) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2EE8840 Offset: 0x2EE8941 VA: 0x2EE8840
	|-ObservableCollection<object>.OnPropertyChanged
	*/

	// RVA: -1 Offset: -1
	private void OnCollectionChanged(NotifyCollectionChangedAction action, object item, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2EE88D0 Offset: 0x2EE89D1 VA: 0x2EE88D0
	|-ObservableCollection<object>.OnCollectionChanged
	*/

	// RVA: -1 Offset: -1
	private void OnCollectionChanged(NotifyCollectionChangedAction action, object oldItem, object newItem, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2EE8970 Offset: 0x2EE8A71 VA: 0x2EE8970
	|-ObservableCollection<object>.OnCollectionChanged
	*/

	// RVA: -1 Offset: -1
	private void OnCollectionReset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2EE8A20 Offset: 0x2EE8B21 VA: 0x2EE8A20
	|-ObservableCollection<object>.OnCollectionReset
	*/
}

