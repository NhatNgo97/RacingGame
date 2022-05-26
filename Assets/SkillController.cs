using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillController : MonoBehaviour
{
    //Dash Skill
    public float startDashTime;
    public bool isDashing = false;
    public Rigidbody2D rb;
    public float speed;
    public float dashForce;
    public float currentDashTimer;
    public float dashDirection;
    public TrailRenderer trailRenderer;
    public bool isDashAvailable = false;

    float movX;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
  
        movX = Input.GetAxis("Vertical");
        if (Input.GetKeyDown(KeyCode.Space) && !isDashing && isDashAvailable)
        {
            isDashing = true;
            isDashAvailable = false;
            currentDashTimer = startDashTime;
            trailRenderer.enabled = true;
        }
      
        dashDirection = (int)movX;
        

        if(isDashing)
        {   
            rb.AddForce(transform.right * dashForce * dashDirection);
            Gradient gradient2 = new Gradient();
                gradient2.SetKeys(
                    new GradientColorKey[] { new GradientColorKey(Color.red, 0.0f), new GradientColorKey(Color.yellow, 1.0f) },
                    new GradientAlphaKey[] { new GradientAlphaKey(1, 0.0f), new GradientAlphaKey(0, 1.0f) }
                );
                trailRenderer.colorGradient = gradient2;
            // rb.velocity = transform.right * dashDirection * dashForce;
            currentDashTimer -= Time.deltaTime;
            if(currentDashTimer <= 0)
            {
                isDashAvailable = false;
                isDashing = false;
            }
        } else {
            Gradient gradient = new Gradient();
                gradient.SetKeys(
                    new GradientColorKey[] { new GradientColorKey(Color.cyan, 0.0f), new GradientColorKey(Color.white, 1.0f) },
                    new GradientAlphaKey[] { new GradientAlphaKey(1, 0.0f), new GradientAlphaKey(0, 1.0f) }
                );
                trailRenderer.colorGradient = gradient;
        }
    }
}
