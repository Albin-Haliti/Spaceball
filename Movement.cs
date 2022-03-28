public class Movement : MonoBehaviour{

    public Ballbody bb;

    void FixedUpdate(){

        bb.AddForce(0, 0, 1500 * Time.deltaTime);
        if(Input.GetKey ("d"))
        {
            bb.AddForce(300 * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey("a")){
            bb.AddForce(-300 * Time.deltaTime, 0, 0);
        }
    }
}
