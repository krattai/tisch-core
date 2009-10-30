/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 1.3.36
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

package libtisch;

public class vectorGesture {
  private long swigCPtr;
  protected boolean swigCMemOwn;

  protected vectorGesture(long cPtr, boolean cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = cPtr;
  }

  protected static long getCPtr(vectorGesture obj) {
    return (obj == null) ? 0 : obj.swigCPtr;
  }

  protected void finalize() {
    delete();
  }

  public synchronized void delete() {
    if(swigCPtr != 0 && swigCMemOwn) {
      swigCMemOwn = false;
      libtischJNI.delete_vectorGesture(swigCPtr);
    }
    swigCPtr = 0;
  }

  public vectorGesture() {
    this(libtischJNI.new_vectorGesture__SWIG_0(), true);
  }

  public vectorGesture(long n) {
    this(libtischJNI.new_vectorGesture__SWIG_1(n), true);
  }

  public long size() {
    return libtischJNI.vectorGesture_size(swigCPtr, this);
  }

  public long capacity() {
    return libtischJNI.vectorGesture_capacity(swigCPtr, this);
  }

  public void reserve(long n) {
    libtischJNI.vectorGesture_reserve(swigCPtr, this, n);
  }

  public boolean isEmpty() {
    return libtischJNI.vectorGesture_isEmpty(swigCPtr, this);
  }

  public void clear() {
    libtischJNI.vectorGesture_clear(swigCPtr, this);
  }

  public void add(Gesture x) {
    libtischJNI.vectorGesture_add(swigCPtr, this, Gesture.getCPtr(x), x);
  }

  public Gesture get(int i) {
    return new Gesture(libtischJNI.vectorGesture_get(swigCPtr, this, i), false);
  }

  public void set(int i, Gesture val) {
    libtischJNI.vectorGesture_set(swigCPtr, this, i, Gesture.getCPtr(val), val);
  }

}
