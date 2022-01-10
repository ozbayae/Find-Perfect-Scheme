using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Timers;
using TMPro;
using Unity.Collections.LowLevel.Unsafe;
using UnityEditor;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.PlayerLoop;

public class ObstacleCourse : MonoBehaviour
{
    [SerializeField] private Interactable startButton;
    [SerializeField] private Interactable finishButton;
    private GameObject[] _targets;
    [SerializeField] private GameObject[] controlSchemes;
    [SerializeField] private GameObject timeUI;
    private PlayerInput _input;
    private Dictionary<int, float> _scores;

    private bool _timerRunning;
    private float _time = 0;
    
    // Start is called before the first frame update


    private void Awake()
    {
        _scores = new Dictionary<int, float>();
        foreach (var scheme in controlSchemes)
        {
            _scores.Add(scheme.GetInstanceID(), float.MaxValue);
        }
        _targets = GameObject.FindGameObjectsWithTag("ObstacleTarget");
        _input = GameObject.FindWithTag("Player").GetComponent<PlayerInput>();
        startButton.Interacted += OnStart;
        finishButton.Interacted += OnFinish;
        foreach (var target in _targets)
        {
            target.transform.GetChild(0).GetComponent<Target>().ShotDown += OnTargetDown;
        }

        timeUI.transform.position += new Vector3(0, -300, 0);
    }

    private void OnTargetDown()
    {
        _time -= 2f;
    }

    private void OnStart()
    {
        //also resets
        if (!timeUI.activeSelf)
        {
            _time = 0;
            _timerRunning = true;
            timeUI.SetActive(true);
            LeanTween.moveY(timeUI, timeUI.transform.position.y + 300, 1f).setEaseInOutCubic();
        }
    }

    private void OnFinish()
    {
        if (_timerRunning)
        {
            Debug.Log("Hello");
            _timerRunning = false;
            //do event with time
            TimeSpan time = TimeSpan.FromSeconds(_time);
            string displayTime = time.ToString("mm':'ss':'ff");
            Debug.Log(displayTime);
            foreach (var scheme in controlSchemes)
            {
                Debug.Log(_input.currentControlScheme);
                if (scheme.name == _input.currentControlScheme && _time < _scores[scheme.GetInstanceID()])
                {
                    scheme.transform.GetChild(2).GetComponent<TextMeshProUGUI>().text = displayTime;
                    _scores[scheme.GetInstanceID()] = _time;
                }
            }

            LeanTween.moveY(timeUI, timeUI.transform.position.y - 300, 1f).setDelay(3f).setEaseInOutCubic()
                .setOnComplete(x => timeUI.SetActive(false));
        }
    }
    
    // Update is called once per frame
    void Update()
    {
        if (_timerRunning)
        {
            _time += Time.deltaTime;
            TimeSpan time = TimeSpan.FromSeconds((double)_time);
            string displayTime = time.ToString("mm':'ss':'ff");
            timeUI.GetComponent<TextMeshProUGUI>().text = displayTime;
        }
        
    }
}
