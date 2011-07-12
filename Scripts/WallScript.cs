using UnityEngine;
using System.Collections;

public class WallScript : MonoBehaviour
{

    private Vector3 m_Pos;
    private Vector3 m_Scale;

    public float StartX;
    public float StartY;
    public float StartLength;
    public float StartWidth;

    public Vector3 Pos
    {
        get
        {
            return m_Pos;
        }
        set
        {
            m_Pos = value;
        }
    }

    public Vector3 Scale
    {
        get
        {
            return m_Scale;
        }
        set
        {
            m_Scale = value;
        }
    }

    void Start ( )
    {
        if ( StartX != null && StartY != null )
            ChangePosition ( StartX, StartY );

        if ( StartLength != null && StartWidth != null )
            ChangeScale ( StartLength, StartWidth );
    }

    void Update ( )
    {

    }

    void ChangeScale ( float Length, float Width )
    {
        m_Scale = new Vector3 ( Length, Width );
        transform.localScale = m_Scale;
    }

    void ChangePosition ( float X, float Y )
    {
        m_Pos = new Vector3 ( X, Y );
        transform.position = m_Pos;
    }
}
