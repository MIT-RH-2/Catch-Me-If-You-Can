using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.MagicLeap;

public class PlanesSnippet : MonoBehaviour
{
    public Transform cameraTransform;
    public Vector3 boundsExtents;
    public GameObject planePrefab;
    public GameObject buildings;
    public MLWorldPlanesQueryFlags QueryFlags;
    private MLWorldPlanesQueryParams _queryParams;
    public AssetBundle bundle ; 
    private List<GameObject> _planeCache = new List<GameObject>();

    void Start()
    {
        // Start Planes.
        MLWorldPlanes.Start();

        // The max number of planes returned by the query.
        _queryParams.MaxResults = 1;

        // Set the Planes Request to repeat every 5 secs.
        InvokeRepeating("RequestPlanes", 1f, 5f);
    }

    private void OnDestroy()
    {
        //Stop Planes.
        MLWorldPlanes.Stop();
    }

    void RequestPlanes()
    {

        // Update the query parameters.
        _queryParams.Flags = QueryFlags;
        _queryParams.BoundsCenter = cameraTransform.position;
        _queryParams.BoundsRotation = cameraTransform.rotation;
        _queryParams.BoundsExtents = boundsExtents;

        // Make planes request with parameter list.
        MLWorldPlanes.GetPlanes(_queryParams, HandleOnReceivedPlanes);
    }

    private void HandleOnReceivedPlanes(MLResult result, MLWorldPlane[] planes,
                                        MLWorldPlaneBoundaries[] boundaries)
    {

        // Empty the planes cache.
        for (int i = _planeCache.Count - 1; i >= 0; --i)
        {
            Destroy(_planeCache[i]);
            _planeCache.Remove(_planeCache[i]);
        }

        // For each plane, instantiate a quad and set the quad dimensions
        // to match the plane.
        for (int i = 0; i < planes.Length; ++i)
        {
            GameObject newPlane = Instantiate(planePrefab);
            GameObject newBuildings = Instantiate(buildings);

            newPlane.transform.position = planes[i].Center;
            newPlane.transform.rotation = planes[i].Rotation;
            newPlane.transform.localScale = new Vector3(planes[i].Width,
                                                        planes[i].Height, 1f);

            float scale = 0.2f;
            float w = planes[i].Width*scale;
            float h = planes[i].Height*scale;
            newBuildings.transform.localScale = new Vector3(w,
                                                       h, 1f);
            newBuildings.transform.position = planes[i].Center;
            _planeCache.Add(newPlane);
            _planeCache.Add(newBuildings);
        }
    }
}
