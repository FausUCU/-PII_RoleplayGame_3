namespace RoleplayGame
{
    public interface IDefenseItem: IItem
    {
        /*Mantengo Iteam, IDefenseItem e IAttackIteam  como interfaces en lugar 
        de classes porque no necesito implemenatlas, 
        no me haorran codigo y una classe necesita heredar de deffensa y 
        attacke, pero no hay multiple herencia en C# */
        int DefenseValue { get; }
    }
}