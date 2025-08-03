using UI;

namespace Management
{
    public class SceneManager 
    {
        private static CanvasHandler _canvasHandle;
        private static SceneData _sceneData;
        
        public static void Initiate(CanvasHandler canvasHandler, SceneData sceneData)
        {
            _canvasHandle = canvasHandler;
            _sceneData = sceneData;
        }

        public static CanvasHandler GetCanvas()
        {
            return _canvasHandle != null ? _canvasHandle : null;
        }
        public static SceneData GetSceneData()
        {
            return _sceneData != null ? _sceneData : null;
        }
    }
}
