using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SLua;
using System.IO;


public class s : MonoBehaviour {
    void Start()
    {
        LuaSvr svr = new LuaSvr();// 如果不先进行某个LuaSvr的初始化的话,下面的mianState会爆一个为null的错误..

        LuaFunction luaFunction = null;
        //LuaSvr.mainState.loaderDelegate += LuaReourcesFileLoader;
        svr.init(null, () => // 如果不用init方法初始化的话,在Lua中是不能import的
        {
            svr.start("test");
            luaFunction = LuaSvr.mainState.getFunction("Awake");

            if (luaFunction != null)
            {
                luaFunction.call();
            }
        });
    }

    // SLua Loader代理方法
    private static byte[] LuaReourcesFileLoader(string strFile,ref string fn)
    {
        // 这里为了测试就不先判断为空,开发的时候再加上
        string filename = Application.dataPath + "/Scripts/Lua/" + strFile.Replace('.', '/') + ".txt";
        return File.ReadAllBytes(filename);
    }

}
