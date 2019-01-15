using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class media {

}

public class music : media {
    public music() {

    }
}

public class vedio : media {
    public vedio() {

    }
}

public abstract class IFactory{
    public abstract void Create();	
}

