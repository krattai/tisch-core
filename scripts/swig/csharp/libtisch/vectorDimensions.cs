/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 1.3.36
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


using System;
using System.Runtime.InteropServices;

public class vectorDimensions : IDisposable, System.Collections.IEnumerable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal vectorDimensions(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(vectorDimensions obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~vectorDimensions() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if(swigCPtr.Handle != IntPtr.Zero && swigCMemOwn) {
        swigCMemOwn = false;
        libtischPINVOKE.delete_vectorDimensions(swigCPtr);
      }
      swigCPtr = new HandleRef(null, IntPtr.Zero);
      GC.SuppressFinalize(this);
    }
  }

  public vectorDimensions(System.Collections.ICollection c) : this() {
    if (c == null)
      throw new ArgumentNullException("c");
    foreach (Dimensions element in c) {
      this.Add(element);
    }
  }

  public bool IsFixedSize {
    get {
      return false;
    }
  }

  public bool IsReadOnly {
    get {
      return false;
    }
  }

  public Dimensions this[int index]  {
    get {
      return getitem(index);
    }
    set {
      setitem(index, value);
    }
  }

  public int Capacity {
    get {
      return (int)capacity();
    }
    set {
      if (value < size())
        throw new ArgumentOutOfRangeException("Capacity");
      reserve((uint)value);
    }
  }

  public int Count {
    get {
      return (int)size();
    }
  }

  public bool IsSynchronized {
    get {
      return false;
    }
  }

  public void CopyTo(System.Array array) {
    CopyTo(0, array, 0, this.Count);
  }

  public void CopyTo(System.Array array, int arrayIndex) {
    CopyTo(0, array, arrayIndex, this.Count);
  }

  public void CopyTo(int index, System.Array array, int arrayIndex, int count) {
    if (array == null)
      throw new ArgumentNullException("array");
    if (index < 0)
      throw new ArgumentOutOfRangeException("index", "Value is less than zero");
    if (arrayIndex < 0)
      throw new ArgumentOutOfRangeException("arrayIndex", "Value is less than zero");
    if (count < 0)
      throw new ArgumentOutOfRangeException("count", "Value is less than zero");
    if (array.Rank > 1)
      throw new ArgumentException("Multi dimensional array.");
    if (index+count > this.Count || arrayIndex+count > array.Length)
      throw new ArgumentException("Number of elements to copy is too large.");
    for (int i=0; i<count; i++)
      array.SetValue(getitemcopy(index+i), arrayIndex+i);
  }

  // Type-safe version of IEnumerable.GetEnumerator
  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() {
    return new vectorDimensionsEnumerator(this);
  }

  public vectorDimensionsEnumerator GetEnumerator() {
    return new vectorDimensionsEnumerator(this);
  }

  // Type-safe enumerator
  /// Note that the IEnumerator documentation requires an InvalidOperationException to be thrown
  /// whenever the collection is modified. This has been done for changes in the size of the
  /// collection but not when one of the elements of the collection is modified as it is a bit
  /// tricky to detect unmanaged code that modifies the collection under our feet.
  public sealed class vectorDimensionsEnumerator : System.Collections.IEnumerator {
    private vectorDimensions collectionRef;
    private int currentIndex;
    private object currentObject;
    private int currentSize;

    public vectorDimensionsEnumerator(vectorDimensions collection) {
      collectionRef = collection;
      currentIndex = -1;
      currentObject = null;
      currentSize = collectionRef.Count;
    }

    // Type-safe iterator Current
    public Dimensions Current {
      get {
        if (currentIndex == -1)
          throw new InvalidOperationException("Enumeration not started.");
        if (currentIndex > currentSize - 1)
          throw new InvalidOperationException("Enumeration finished.");
        if (currentObject == null)
          throw new InvalidOperationException("Collection modified.");
        return (Dimensions)currentObject;
      }
    }

    // Type-unsafe IEnumerator.Current
    object System.Collections.IEnumerator.Current {
      get {
        return Current;
      }
    }

    public bool MoveNext() {
      int size = collectionRef.Count;
      bool moveOkay = (currentIndex+1 < size) && (size == currentSize);
      if (moveOkay) {
        currentIndex++;
        currentObject = collectionRef[currentIndex];
      } else {
        currentObject = null;
      }
      return moveOkay;
    }

    public void Reset() {
      currentIndex = -1;
      currentObject = null;
      if (collectionRef.Count != currentSize) {
        throw new InvalidOperationException("Collection modified.");
      }
    }
  }

  public void Clear() {
    libtischPINVOKE.vectorDimensions_Clear(swigCPtr);
  }

  public void Add(Dimensions x) {
    libtischPINVOKE.vectorDimensions_Add(swigCPtr, Dimensions.getCPtr(x));
    if (libtischPINVOKE.SWIGPendingException.Pending) throw libtischPINVOKE.SWIGPendingException.Retrieve();
  }

  private uint size() {
    uint ret = libtischPINVOKE.vectorDimensions_size(swigCPtr);
    return ret;
  }

  private uint capacity() {
    uint ret = libtischPINVOKE.vectorDimensions_capacity(swigCPtr);
    return ret;
  }

  private void reserve(uint n) {
    libtischPINVOKE.vectorDimensions_reserve(swigCPtr, n);
  }

  public vectorDimensions() : this(libtischPINVOKE.new_vectorDimensions__SWIG_0(), true) {
  }

  public vectorDimensions(int capacity) : this(libtischPINVOKE.new_vectorDimensions__SWIG_1(capacity), true) {
    if (libtischPINVOKE.SWIGPendingException.Pending) throw libtischPINVOKE.SWIGPendingException.Retrieve();
  }

  private Dimensions getitemcopy(int index) {
    Dimensions ret = new Dimensions(libtischPINVOKE.vectorDimensions_getitemcopy(swigCPtr, index), true);
    if (libtischPINVOKE.SWIGPendingException.Pending) throw libtischPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private Dimensions getitem(int index) {
    Dimensions ret = new Dimensions(libtischPINVOKE.vectorDimensions_getitem(swigCPtr, index), false);
    if (libtischPINVOKE.SWIGPendingException.Pending) throw libtischPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private void setitem(int index, Dimensions val) {
    libtischPINVOKE.vectorDimensions_setitem(swigCPtr, index, Dimensions.getCPtr(val));
    if (libtischPINVOKE.SWIGPendingException.Pending) throw libtischPINVOKE.SWIGPendingException.Retrieve();
  }

  public void AddRange(vectorDimensions values) {
    libtischPINVOKE.vectorDimensions_AddRange(swigCPtr, vectorDimensions.getCPtr(values));
    if (libtischPINVOKE.SWIGPendingException.Pending) throw libtischPINVOKE.SWIGPendingException.Retrieve();
  }

  public vectorDimensions GetRange(int index, int count) {
    IntPtr cPtr = libtischPINVOKE.vectorDimensions_GetRange(swigCPtr, index, count);
    vectorDimensions ret = (cPtr == IntPtr.Zero) ? null : new vectorDimensions(cPtr, true);
    if (libtischPINVOKE.SWIGPendingException.Pending) throw libtischPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void Insert(int index, Dimensions x) {
    libtischPINVOKE.vectorDimensions_Insert(swigCPtr, index, Dimensions.getCPtr(x));
    if (libtischPINVOKE.SWIGPendingException.Pending) throw libtischPINVOKE.SWIGPendingException.Retrieve();
  }

  public void InsertRange(int index, vectorDimensions values) {
    libtischPINVOKE.vectorDimensions_InsertRange(swigCPtr, index, vectorDimensions.getCPtr(values));
    if (libtischPINVOKE.SWIGPendingException.Pending) throw libtischPINVOKE.SWIGPendingException.Retrieve();
  }

  public void RemoveAt(int index) {
    libtischPINVOKE.vectorDimensions_RemoveAt(swigCPtr, index);
    if (libtischPINVOKE.SWIGPendingException.Pending) throw libtischPINVOKE.SWIGPendingException.Retrieve();
  }

  public void RemoveRange(int index, int count) {
    libtischPINVOKE.vectorDimensions_RemoveRange(swigCPtr, index, count);
    if (libtischPINVOKE.SWIGPendingException.Pending) throw libtischPINVOKE.SWIGPendingException.Retrieve();
  }

  public static vectorDimensions Repeat(Dimensions value, int count) {
    IntPtr cPtr = libtischPINVOKE.vectorDimensions_Repeat(Dimensions.getCPtr(value), count);
    vectorDimensions ret = (cPtr == IntPtr.Zero) ? null : new vectorDimensions(cPtr, true);
    if (libtischPINVOKE.SWIGPendingException.Pending) throw libtischPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void Reverse() {
    libtischPINVOKE.vectorDimensions_Reverse__SWIG_0(swigCPtr);
  }

  public void Reverse(int index, int count) {
    libtischPINVOKE.vectorDimensions_Reverse__SWIG_1(swigCPtr, index, count);
    if (libtischPINVOKE.SWIGPendingException.Pending) throw libtischPINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetRange(int index, vectorDimensions values) {
    libtischPINVOKE.vectorDimensions_SetRange(swigCPtr, index, vectorDimensions.getCPtr(values));
    if (libtischPINVOKE.SWIGPendingException.Pending) throw libtischPINVOKE.SWIGPendingException.Retrieve();
  }

}
