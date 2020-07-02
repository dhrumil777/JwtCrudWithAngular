export class Employee {
    public constructor(init?: Partial<Employee>) {
        Object.assign(this, init);
    }
    EmployeeName:string;
    DeparmentName:string;
    hobbies:string;    
}
