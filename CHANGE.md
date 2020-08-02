## All Versions

### v0.3.6

- **JAction** which **supports less code but do more**

  ```c#
  JAction j = new JAction();
  j.Do(() =>
        {
          Log.Print("Hello from JAction!");
        })
    .Delay(3.0f)
    .Do(() =>
        {
          Log.Print("Bye from JAction");
        })
    .Excute();
  ```

  

- Hidden dictionary to save Hot Update DLL which **strongly increased unity excute speed for dll** (Unity will no longer load Hot Update DLL from editor)



### v0.3.5

- **Rewrite JBehaviour's source code** which enhances the performence
- **JObjectPool** is a new **solution for Object Pool**
- **Improve JBehaviour** which it now **supports method-chaning** in some part
- **Enhance JUI**



### v0.3.4

- **JBehaviour Example**
- **Rewrite** JBehaviour **Structure**
- **Improve** JUI
- **Fix** that **JBehaviou**r can't be called



### v0.3.3

- **Hot Update DLL Encryption** based on AES encryption, with a 16 bits key, it is harder to let others hack your dll
- More **ILRuntime Registerations support**, reduce the requirements of registerations when using ILRuntime
- Update **XAsset** and **ILRuntime** to the latest version



### v0.3.2

- **JUIText** becomes **JUI**

  - Supports any **UIBehaviour based class** to use

    > All UGUI components in Unity is UIBehaviour based

- **JUI** supports **data binding**

- **JUI** supports **message mode**, will be called when binded data has changed

- **BindableProperty** is coming, use it in your data class or sturcts

- Improve performence of looping in **JUIBehaviour**

- Improve performence on getting **generic components** in JUI

- Update showcases to a countdown showcase and a data update & binding showcase





###  v0.3.1

- Combined **Unity-GUI-Redis**, which is also part of **JEngine**, now belongs to **JEngine.Redis** namespace

- Update **XAsset** dependency to latest version:

  - Supports **network monitor**
  - Build bundles name by **hash**
  - Tiny improvment on the framework

- Rewrite **ILRuntime**:

  - Supports **OnDestory** method called by MonoBehaviour
  - Tiny improvment on the framework

- **JUI** is now coming:

  > Only supports Text at the moment

  - Based on **JUIBehaviour**
  - **Method-Chaining** which makes more stramlined and beautiful codes
  - Unique and managable **lifecycle**

- Improve **JUIBehaviour**



### v0.3

- Update **ILRuntime** to v1.6.3 which fixes heaps of bugs in the dependency
- **JEngine Lifecyle** is now included, it is **only a prototype** and will be extended in the future with more base codes.
- **JUIBehaviour** is coming, it is a behaviour base on MonoBehaviour but more friendly to manage UI components' lifecycles which are not require to change that frequently, **and runs better**, you can use less codes to implement more



### v0.2

- Supports development mode which **loads dll and resources from local**
- Automatically **clean up unnecessary dlls, pdbs, etc.** in DLL Resource Directory
- Automatically **convert dll into bytes** in Editor



### v0.1

- Automatically generate **Update Resources**
- Automatically handle **Hot-update DLL**
- Update [Hot-update](https://github.com/JasonXuDeveloper/JEngine/blob/4d63fec4027ff5c546fb15ec2469ead898922858/README.md#What-is-Hot-update) codes and resources from server (Base on XAsset & ILRuntime)
- Supports local hot-update code development in Unity Editor via dll in Asstes/HotUpdateResources/Dll/HotUpdateScripts.dll

