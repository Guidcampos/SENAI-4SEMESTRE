import React from 'react';
import './Task.css'

const Task = ({checked}) => {
    return (
        <div className='container-task'>
            <div className='checkbox'>

            </div>
            <p style={{color: 'black'}}>Começar a execução do projeto</p>
            <div className='delete'>
                
            </div>
            <div className='editar'>

            </div>
        </div>
    );
};

export default Task;