using System;
using System.Collections.Generic;
using System.Text;
using BepInEx;
using Photon.Pun;
using UnityEngine;
using UnityEngine.InputSystem;

namespace StupidTemplate.Menu
{
    class mods
    {
        public static void Disconnect()
        {
            PhotonNetwork.Disconnect();
        }

        public static void orbitfast()
        {
            Main.orbitSpeed = 2f;
        }

        public static void orbitnormalspeed()
        {
            Main.orbitSpeed = 1f;
        }

        public static void orbitslow()
        {
            Main.orbitSpeed = 0.5f;
        }

        public static void orbitfar()
        {
            Main.orbitRadius = 1.5f;
        }

        public static void orbitnormal()
        {
            Main.orbitRadius = 1f;
        }

        public static void orbitclose()
        {
            Main.orbitRadius = 0.5f;
        }
        public static void placeholder()
        {

        }

        private static GameObject GunSphere;
        private static LineRenderer lineRenderer;
        private static float timeCounter = 0f;
        private static Vector3[] linePositions;
        private static Vector3 previousControllerPosition;

        public static void AetherGunTemplate()
        {
            if (ControllerInputPoller.instance.rightControllerGripFloat > 0.1f || Mouse.current.rightButton.isPressed)
            {
                if (Physics.Raycast(
                        GorillaLocomotion.Player.Instance.rightControllerTransform.position,
                        -GorillaLocomotion.Player.Instance.rightControllerTransform.up, out var hitinfo))
                {
                    if (Mouse.current.rightButton.isPressed)
                    {
                        Camera cam = GameObject.Find("Shoulder Camera").GetComponent<Camera>();
                        Ray ray = cam.ScreenPointToRay(Mouse.current.position.ReadValue());
                        Physics.Raycast(ray, out hitinfo, 100);
                    }

                    if (GunSphere == null)
                    {
                        GunSphere = GameObject.CreatePrimitive(PrimitiveType.Sphere);
                        GunSphere.transform.localScale = new Vector3(0f, 0f, 0f);
                        GunSphere.GetComponent<Renderer>().material.shader = Shader.Find("GorillaTag/UberShader");
                        GunSphere.GetComponent<Renderer>().material.color = Color.white;
                        GameObject.Destroy(GunSphere.GetComponent<BoxCollider>());
                        GameObject.Destroy(GunSphere.GetComponent<Rigidbody>());
                        GameObject.Destroy(GunSphere.GetComponent<Collider>());

                        lineRenderer = GunSphere.AddComponent<LineRenderer>();
                        lineRenderer.material = new Material(Shader.Find("Sprites/Default"));
                        lineRenderer.widthCurve = AnimationCurve.Linear(0, 0.01f, 1, 0.01f);
                        lineRenderer.startColor = Color.white;
                        lineRenderer.endColor = Color.white;

                        linePositions = new Vector3[50];
                        for (int i = 0; i < linePositions.Length; i++)
                        {
                            linePositions[i] = GorillaLocomotion.Player.Instance.rightControllerTransform.position;
                        }
                    }

                    GunSphere.transform.position = hitinfo.point;

                    timeCounter += Time.deltaTime;

                    Vector3 pos1 = GorillaLocomotion.Player.Instance.rightControllerTransform.position;
                    float distance = Vector3.Distance(pos1, hitinfo.point);
                    previousControllerPosition = pos1;
                    const float spiralTurns = 4f;
                    const float maxAmplitude = 0.1f;

                    for (int i = 0; i < linePositions.Length; i++)
                    {
                        float t = i / (float)(linePositions.Length - 1);
                        Vector3 basePos = Vector3.Lerp(pos1, hitinfo.point, t);
                        Vector3 forward = (hitinfo.point - pos1).normalized;
                        Vector3 up = Vector3.up;
                        if (Mathf.Abs(Vector3.Dot(forward, up)) > 0.9f)
                        {
                            up = Vector3.right;
                        }
                        Vector3 right = Vector3.Cross(forward, up).normalized;
                        up = Vector3.Cross(right, forward).normalized;
                        float spiralAngle = t * 2f * Mathf.PI * spiralTurns + timeCounter;
                        float spiralAmplitude = (1f - t) * maxAmplitude;
                        Vector3 offset = right * (Mathf.Cos(spiralAngle) * spiralAmplitude) +
                                         up * (Mathf.Sin(spiralAngle) * spiralAmplitude);

                        Vector3 newPos = basePos + offset;
                        linePositions[i] = Vector3.Lerp(linePositions[i], newPos, Time.deltaTime * 5f);
                    }

                    lineRenderer.positionCount = linePositions.Length;
                    lineRenderer.SetPositions(linePositions);

                    float colorLerp = Mathf.PingPong(timeCounter, 1f);
                    Color lineColor = Color.Lerp(Color.white, Color.cyan, colorLerp);
                    lineRenderer.startColor = lineColor;
                    lineRenderer.endColor = lineColor;
                }
            }
            else if (GunSphere != null && (ControllerInputPoller.instance.rightControllerGripFloat <= 0.1f && !Mouse.current.rightButton.isPressed))
            {
                GameObject.Destroy(GunSphere);
                GameObject.Destroy(lineRenderer);
                timeCounter = 0f;
                linePositions = null;
            }
        }



    }
}
