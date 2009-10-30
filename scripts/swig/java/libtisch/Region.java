/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 1.3.36
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

package libtisch;

public class Region extends vectorVector {
  private long swigCPtr;

  protected Region(long cPtr, boolean cMemoryOwn) {
    super(libtischJNI.SWIGRegionUpcast(cPtr), cMemoryOwn);
    swigCPtr = cPtr;
  }

  protected static long getCPtr(Region obj) {
    return (obj == null) ? 0 : obj.swigCPtr;
  }

  protected void finalize() {
    delete();
  }

  public synchronized void delete() {
    if(swigCPtr != 0 && swigCMemOwn) {
      swigCMemOwn = false;
      libtischJNI.delete_Region(swigCPtr);
    }
    swigCPtr = 0;
    super.delete();
  }

  public Region(int _flags) {
    this(libtischJNI.new_Region__SWIG_0(_flags), true);
  }

  public Region() {
    this(libtischJNI.new_Region__SWIG_1(), true);
  }

  public int contains(Vector v) {
    return libtischJNI.Region_contains(swigCPtr, this, Vector.getCPtr(v), v);
  }

  public int flags() {
    return libtischJNI.Region_flags__SWIG_0(swigCPtr, this);
  }

  public void flags(int _flags) {
    libtischJNI.Region_flags__SWIG_1(swigCPtr, this, _flags);
  }

  public void setGestures(vectorGesture value) {
    libtischJNI.Region_gestures_set(swigCPtr, this, vectorGesture.getCPtr(value), value);
  }

  public vectorGesture getGestures() {
    long cPtr = libtischJNI.Region_gestures_get(swigCPtr, this);
    return (cPtr == 0) ? null : new vectorGesture(cPtr, false);
  }

}
