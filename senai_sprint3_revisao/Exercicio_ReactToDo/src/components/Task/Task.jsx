import React from 'react';
import './Task.css'
import editaricon from '../../assets/Group 13.png'
import editariconBranco from '../../assets/Group 13 (1).png'
import deleteicon from '../../assets/Group 8.png'
import deleteiconbranco from '../../assets/Group 8 (1).png'
import checkicon from '../../assets/check.svg'
// , checked = false
const Task = ({tasks = [{titulo: "teste", checked: false},{titulo: "teste2", checked: true}]}) => {
    return (
        tasks.map((task, index) => (
        
        <div key={index} className='container-task' style={{backgroundColor: task.checked ? '#6C45CE' : ""}}>
            <div className='checkbox' style={{backgroundColor: task.checked ? '#1E123B' : ""}}>
            {!task.checked ? <></> :
            <img src={checkicon} alt="" />
             }
            </div>
            <p style={{color: !task.checked ? '#25282C' : '#FFFFFF', textAlign: 'left', width: 507}}>{task.titulo}</p>
            <div className="botoes">

            <div className='delete' style={{borderColor: task.checked ? '#FFFFFF' : ""}}>
           
                <img src={!task.checked ? deleteicon : deleteiconbranco} alt="" />
            </div>
            <div className='editar' style={{borderColor: task.checked ? '#FFFFFF' : ""}}>
            
                <img src={!task.checked ? editaricon : editariconBranco} alt="" />
            
            </div>
            </div>
        </div> 

        ))
    );
};

export default Task;