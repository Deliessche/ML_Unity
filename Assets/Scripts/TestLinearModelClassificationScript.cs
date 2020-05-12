﻿using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;

public class TestLinearModelClassificationScript : MonoBehaviour
{
    public Transform[] trainSpheresTransforms;

    public Transform[] testSpheresTransforms;

    public void TrainAndTest()
    {
        Debug.Log("Training and Testing");

        // Créer dataset_inputs
        double[] dataset_inputs = new double[trainSpheresTransforms.Length * 2];
        for (int i = 0; i < trainSpheresTransforms.Length; i++)
        {
            dataset_inputs[i*2] = trainSpheresTransforms[i].position.x;
            dataset_inputs[i * 2 + 1] = trainSpheresTransforms[i].position.z;
        }

        // Créer dataest_expected_outputs
        double[] Y = new double[trainSpheresTransforms.Length];
        int cpt = 0;
        foreach (var sphere in trainSpheresTransforms)
        {
            Y[cpt] = sphere.position.y;
            cpt++;
        }
        // Create Model
        //double[] modeldouble = ClionLibWrapper.linear_model_create(2)
        IntPtr model = CLionLibWrapper.linear_model_create(2);
        
        // Train Model
        CLionLibWrapper.linear_model_train_classification(model, dataset_inputs, trainSpheresTransforms.Length, 2, Y, Y.Length,
            1000000, 0.01f);
        // For each testSphere : Predict 
        foreach (var Sphere in testSpheresTransforms)
        {
            double[] input =
            {
                Sphere.position.x, Sphere.position.y
            };
            float y = (float)CLionLibWrapper.linear_model_predict_classification(model, input, 2); //2
            Sphere.position = new Vector3(
                Sphere.position.x,
                y,
                Sphere.position.z
            );
            //testSpheresTransform.position += Vector3.up * 10;
        }

        // Delete Model
    }public void TrainAndTestForNonLinearButOk()
    {
        Debug.Log("Training and Testing");

        // Créer dataset_inputs
        double[] dataset_inputs = new double[trainSpheresTransforms.Length * 2];
        for (int i = 0; i < trainSpheresTransforms.Length; i++)
        {
            dataset_inputs[i*2] = trainSpheresTransforms[i].position.x * trainSpheresTransforms[i].position.x;
            dataset_inputs[i * 2 + 1] = trainSpheresTransforms[i].position.z * trainSpheresTransforms[i].position.z;
        }

        // Créer dataest_expected_outputs
        double[] Y = new double[trainSpheresTransforms.Length];
        int cpt = 0;
        foreach (var sphere in trainSpheresTransforms)
        {
            Y[cpt] = sphere.position.y;
            cpt++;
        }
        // Create Model
        //double[] modeldouble = ClionLibWrapper.linear_model_create(2)
        IntPtr model = CLionLibWrapper.linear_model_create(2);
        
        // Train Model
        CLionLibWrapper.linear_model_train_classification(model, dataset_inputs, trainSpheresTransforms.Length, 2, Y, Y.Length,
            1000000, 0.01f);
        // For each testSphere : Predict 
        foreach (var Sphere in testSpheresTransforms)
        {
            double[] input =
            {
                Sphere.position.x, Sphere.position.y
            };
            float y = (float)CLionLibWrapper.linear_model_predict_classification(model, input, 2); //2
            Sphere.position = new Vector3(
                Sphere.position.x,
                y,
                Sphere.position.z
            );
            //testSpheresTransform.position += Vector3.up * 10;
        }

        // Delete Model
    }
    public void TrainAndTestRegression()
    {
        Debug.Log("Training and Testing");

        // Créer dataset_inputs
        double[] dataset_inputs = new double[trainSpheresTransforms.Length * 2];
        for (int i = 0; i < trainSpheresTransforms.Length; i++)
        {
            dataset_inputs[i*2] = trainSpheresTransforms[i].position.x;
            dataset_inputs[i * 2 + 1] = trainSpheresTransforms[i].position.z;
        }

        // Créer dataest_expected_outputs
        double[] Y = new double[trainSpheresTransforms.Length];
        int cpt = 0;
        foreach (var sphere in trainSpheresTransforms)
        {
            Y[cpt] = sphere.position.y;
            cpt++;
        }
        // Create Model
        //double[] modeldouble = ClionLibWrapper.linear_model_create(2)
        IntPtr model = CLionLibWrapper.linear_model_create(2);
        
        // Train Model
        CLionLibWrapper.linear_model_train_regression(model, dataset_inputs, trainSpheresTransforms.Length, 2, Y, Y.Length);
        // For each testSphere : Predict 
        foreach (var Sphere in testSpheresTransforms)
        {
            double[] input =
            {
                Sphere.position.x, Sphere.position.y
            };
            float y = (float)CLionLibWrapper.linear_model_predict_regression(model, input, 2); //2
            Sphere.position = new Vector3(
                Sphere.position.x,
                y,
                Sphere.position.z
            );
            //testSpheresTransform.position += Vector3.up * 10;
        }

        // Delete Model
    }
}