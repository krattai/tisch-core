/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 1.3.40
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

package libtisch;

public class mapStringFeatureBaseP {
  private long swigCPtr;
  protected boolean swigCMemOwn;

  protected mapStringFeatureBaseP(long cPtr, boolean cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = cPtr;
  }

  protected static long getCPtr(mapStringFeatureBaseP obj) {
    return (obj == null) ? 0 : obj.swigCPtr;
  }

  protected void finalize() {
    delete();
  }

  public synchronized void delete() {
    if (swigCPtr != 0) {
      if (swigCMemOwn) {
        swigCMemOwn = false;
        libtischJNI.delete_mapStringFeatureBaseP(swigCPtr);
      }
      swigCPtr = 0;
    }
  }

  public mapStringFeatureBaseP() {
    this(libtischJNI.new_mapStringFeatureBaseP__SWIG_0(), true);
  }

  public mapStringFeatureBaseP(mapStringFeatureBaseP arg0) {
    this(libtischJNI.new_mapStringFeatureBaseP__SWIG_1(mapStringFeatureBaseP.getCPtr(arg0), arg0), true);
  }

  public long size() {
    return libtischJNI.mapStringFeatureBaseP_size(swigCPtr, this);
  }

  public boolean empty() {
    return libtischJNI.mapStringFeatureBaseP_empty(swigCPtr, this);
  }

  public void clear() {
    libtischJNI.mapStringFeatureBaseP_clear(swigCPtr, this);
  }

  public FeatureBase get(String key) {
    long cPtr = libtischJNI.mapStringFeatureBaseP_get(swigCPtr, this, key);
    return (cPtr == 0) ? null : new FeatureBase(cPtr, false);
  }

  public void set(String key, FeatureBase x) {
    libtischJNI.mapStringFeatureBaseP_set(swigCPtr, this, key, FeatureBase.getCPtr(x), x);
  }

  public void del(String key) {
    libtischJNI.mapStringFeatureBaseP_del(swigCPtr, this, key);
  }

  public boolean has_key(String key) {
    return libtischJNI.mapStringFeatureBaseP_has_key(swigCPtr, this, key);
  }

}
