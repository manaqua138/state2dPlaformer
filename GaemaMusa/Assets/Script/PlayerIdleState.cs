using UnityEngine;

public class PlayerIdleState : PlayerState
{
    public PlayerIdleState(Player _player, PlayerStateMachine _stateMachine, string _animBoolName) 
        : base(_player, _stateMachine, _animBoolName)
    {
    }

    public override void Enter()
    {
        base.Enter();
    }

    public override void Update()
    {
        base.Update();

        if (Input.GetAxisRaw("Horizontal") != 0 || Input.GetAxisRaw("Vertical") != 0)
        {
            player.stateMachine.ChangeState(player.moveState);
        }

        if (Input.GetKeyDown(KeyCode.J))
        {
            player.stateMachine.ChangeState(player.attackState);
        }

    }

    public override void Exit()
    {
        base.Exit();
    }
}
