var isQuitButton =false;

function OnMouseEnter()
{
renderer.material.color = Color.green;
}

function OnMouseExit()
{
renderer.material.color = Color.white;
}

function OnMouseUp()
{

	if(isQuitButton)
	{
		Application.LoadLevel(4);
	}
	else
	{
		 	Application.LoadLevel(2);
	}



}