import React from 'react';
import './Input.css'
import searchimg from '../../assets/Vector.svg'


const Input = () => {
    return (
        <div className='container-input'>
            <div className='search'>
            <img src={searchimg} alt="" />
            </div>
        <input className='input' placeholder='Procurar tarefa'>
        </input>
        </div>
    );
};

export default Input;