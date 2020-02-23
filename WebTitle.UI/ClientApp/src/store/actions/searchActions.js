import * as types from './actionTypes';
import * as titleApi from '../../api/titleApi';

export function searchTitle(searchCriteria){
  return loadTitles(searchCriteria.TitleName);
}

export function loadTitlesSuccess(titles){
  return {type: types.LOAD_TITLES_SUCCESS, titles};
}

export function loadTitles(name){
  return function(dispatch){
    return titleApi.getTitles(name).then(titles => {
      dispatch(loadTitlesSuccess(titles));
    }).catch(error => {
      throw error;
    })
  }
}

export function loadSingleTitlesSuccess(title){
  return {type: types.LOAD_SINGLE_TITLE_SUCCESS, title};
}

export function loadSingleTitle(titleId){
  return function(dispatch){
    return titleApi.getSingleTitle(titleId).then(title => {
      dispatch(loadSingleTitlesSuccess(title));
    }).catch(error => {
      throw error;
    })
  }
}