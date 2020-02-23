import { handleResponse, handleError } from "./apiUtils";



export function getTitles(name) {
  const baseUrlForTitles = "http://localhost:5000/api/mediatitle/names/";
  return fetch(baseUrlForTitles + name)
    .then(handleResponse)
    .catch(handleError);
}

export function getSingleTitle(name) {
  const baseUrlForSingleTitle = "http://localhost:5000/api/mediatitle/GetById/";
  return fetch(baseUrlForSingleTitle + name)
    .then(handleResponse)
    .catch(handleError);
}





