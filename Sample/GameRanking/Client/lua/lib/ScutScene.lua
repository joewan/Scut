ScutScene = {}
ScutScene.__index = ScutScene

function ScutScene:node()
    scene = CCScene:create()
    local t = tolua.getpeer(scene)
    if not t then
        t = {}
        tolua.setpeer(scene, t)
    end
    setmetatable(t, ScutScene)
    return scene
end

function ScutScene:registerScriptHandler(func)
end

function ScutScene:registerCallback(func)
    func = func or function()end
    self.mCallbackFunc = func
end

function ScutScene:registerNetErrorFunc(func)
    func = func or function()end
    self.mNetErrorFunc = func
end

function ScutScene:registerNetCommonDataFunc(func)
    func = func or function()end
    self.mNetCommonDataFunc = func
end

function ScutScene:registerNetDecodeEnd()
    func = func or function()end
    self.NetDecodeEndFunc = func
end

function ScutScene:execCallback(nTag, nNetState, pData)
    if 2 == nNetState then
        local reader = ScutDataLogic.CDataRequest:Instance()
        local bValue = reader:LuaHandlePushDataWithInt(pData)
        if not bValue then return end
        if self.mCallbackFunc then
            self.mCallbackFunc(self)
        end

        if self.mNetCommonDataFunc then
            self.mNetCommonDataFunc()
        end

        netDecodeEnd(self, nTag)

        if self.mNetErrorFunc then
            self.mNetErrorFunc()
        end
    end
end